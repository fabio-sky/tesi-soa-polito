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

    Coroutine _lastCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        _blockCounter = 0;

        _sessionBlocks = GameManager.Instance.SessionInProgress.SessionBlocksList.ToArray();

        if(_sessionBlocks.Length > 0)
        {
            _blockInProgress = _sessionBlocks[0];
            GameManager.Instance.StartHandLogging();
        }
        else
        {
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
        _tryCounter++;



        if(_blockInProgress.target == SessionBlock.TargetBehaviour.RANDOM) {

            spawnPoint = Random.Range(0, targetSpawnPoints.Length);
        }

        // spawn del target
        Instantiate(targetPrefab, targetSpawnPoints[spawnPoint].position, Quaternion.Euler(0, 90, 0));
        _isWaiting = false;
    }

    void NextBlock()
    {
        _blockCounter++;
        
        if(_blockCounter >= _sessionBlocks.Length)
        {
            GameManager.Instance.EndSession();
        }
        else
        {
            _blockInProgress = _sessionBlocks[_blockCounter];
            StartWait();
        }
    }


    //PUBLIC METHODS

    public void ButtonPress()
    {
        if (!_isWaiting)
            GameManager.Instance.SessionLogger.LogWorldUpdate(SessionLogger.SessionAction.BUTTON_PRESSED);

        if (_tryCounter >= _blockInProgress.numberOfTry)
        {
            NextBlock();
        }
        else
            StartWait();
    }
    public void ButtonRelease() 
    {
        
        if (_isWaiting)
        {
            StopCoroutine(_lastCoroutine);
            return;
        }

        //Log start of the movement
        GameManager.Instance.SessionLogger.LogWorldUpdate(SessionLogger.SessionAction.BUTTON_RELEASED);
    }

    public void TargetReached()
    {
        GameManager.Instance.SessionLogger.LogWorldUpdate(SessionLogger.SessionAction.TARGET_REACHED);
    }


    //COROUTINES
    IEnumerator WaitRestTime(int waitValue)
    {
        _isWaiting = true;
        yield return new WaitForSeconds(waitValue);
        NextTry();
    }

}
