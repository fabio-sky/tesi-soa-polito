using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SessionManager : MonoBehaviour
{

    #region Singleton Creation
    public static SessionManager Instance { get; private set; }

    private SessionManager()
    {
        // Private constructor to prevent instantiation from outside the class.
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;
    }
    #endregion

    [SerializeField] GameObject targetPrefab;
    [SerializeField] Transform[] targetSpawnPoints;

    SessionBlock[] _sessionBlocks;
    public SessionBlock[] SessionBlocks { set { _sessionBlocks = value; } get { return _sessionBlocks; } }

    SessionBlock _blockInProgress;
    //public SessionBlock BlockInProgress { get { return _blockInProgress; } }

    int _blockCounter;
    public int BlockIndexInProgress { get { return _blockCounter; } }
    int _tryCounter;
    public int TryInProgress { get { return _tryCounter; } }

    bool _isWaiting;
    bool _tagetAlreadyReached = false;
    bool _fakePress = false;
    Coroutine _lastCoroutine;


    public void InitializeSession()
    {
        _blockCounter = 0;
        _tryCounter = 0;

        _sessionBlocks = GameManager.Instance.SessionInProgress.SessionBlocksList.ToArray();

        if (_sessionBlocks.Length > 0)
        {
            Debug.Log("SessionManager start logging");
            _blockInProgress = _sessionBlocks[0];
            //GameManager.Instance.WorldData.Delay = _blockInProgress.delay;
            //GameManager.Instance.DEBUG_AddToLog(GameManager.Instance.WorldData.Delay.ToString() + " | " + _blockInProgress.delay);
            //GameManager.Instance.StartHandLogging();
            //GameManager.Instance.SettingsData.SessionEnable = true;
        }
        else
        {
            StopCoroutine(_lastCoroutine);
            GameManager.Instance.EndSession();
        }
    }

    void StartWait() 
    {
        if(!_isWaiting) {
            _lastCoroutine = StartCoroutine(WaitRestTime(_blockInProgress.restTime));
        }
        
    }

    void NextTry()
    {
        int spawnPoint = 0;
        //_tryCounter++;



        if(_blockInProgress.target == SessionBlock.TargetBehaviour.RANDOM) {

            spawnPoint = Random.Range(0, targetSpawnPoints.Length);
        }

        // spawn del target
        Instantiate(targetPrefab, targetSpawnPoints[spawnPoint].position, Quaternion.Euler(0, 90, 0));
        _isWaiting = false;
    }


    //PUBLIC METHODS

    public void ButtonPress()
    {

        if (!GameManager.Instance.SettingsData.SessionEnable) return;
        
        Debug.Log("SessionManager: BUTTON PRESSED");
        bool ended = false;

        _tagetAlreadyReached = false;

        if (_isWaiting) { return; }

        if(_tryCounter == 0) {

            GameManager.Instance.WorldData.Delay = _blockInProgress.delay;

        }

        if (!_fakePress)
        {
            _tryCounter++;
        }
            

        if (_tryCounter > _blockInProgress.numberOfTry)
        {
            _blockCounter++;
            _tryCounter = 1;

            if (_blockCounter >= _sessionBlocks.Length)
            {
                ended = true;
                StopCoroutine(_lastCoroutine);
                GameManager.Instance.EndSession();
            }
            else
            {
                _blockInProgress = _sessionBlocks[_blockCounter];
                GameManager.Instance.WorldData.Delay = _blockInProgress.delay;
                GameManager.Instance.DEBUG_AddToLog(GameManager.Instance.WorldData.Delay.ToString() + " | " + _blockInProgress.delay);
            }

            //NextBlock();

        }

        if(!ended)
        {
            if (!_fakePress)
                GameManager.Instance.SessionLogger.LogWorldUpdate(SessionLogger.SessionAction.BUTTON_PRESSED);

            _fakePress = false;
            StartWait();
        }
        
    }
    public void ButtonRelease() 
    {
        
        if (!GameManager.Instance.SettingsData.SessionEnable) return;
        Debug.Log("SessionManager: BUTTON RELEASED");

        if (_isWaiting)
        {
            StopCoroutine(_lastCoroutine);
            _isWaiting = false;
            _fakePress = true;
            return;
        }

        //Log start of the movement
        GameManager.Instance.SessionLogger.LogWorldUpdate(SessionLogger.SessionAction.BUTTON_RELEASED);
    }

    public void TargetReached()
    {
        if (!_tagetAlreadyReached)
        {
            _tagetAlreadyReached = true;
            GameManager.Instance.SessionLogger.LogWorldUpdate(SessionLogger.SessionAction.TARGET_REACHED);
        }
        
    }


    //COROUTINES
    IEnumerator WaitRestTime(int waitValue)
    {
        _isWaiting = true;
        yield return new WaitForSeconds(waitValue);
        NextTry();
    }

}
