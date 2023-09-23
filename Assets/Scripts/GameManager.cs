using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

enum SkyboxType
{
    WAITING,
    ROOM,
}

enum GameScene
{
    WAIT_SCENE,
    ROOM_SCENE,
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Scriptable objects containing World and Settings parameters")]
    [SerializeField] WorldData _worldData;
    public WorldData WorldData
    {
        get
        {
            return _worldData;
        }
    }

    [SerializeField] SettingsData _settingsData;


    [SerializeField] TextMeshProUGUI _textLogger;

    public SettingsData SettingsData
    {
        get
        {
            return _settingsData;
        }
    }

    //[Header("Real tracked hand and follow hand needed to log positions")]
    //Transform _rightHandReal;
    //Transform _rightHandFollow;

    //Transform _leftHandReal;
    //Transform _leftHandFollow;

    //[SerializeField] GameObject _leftHandController;
    //[SerializeField] GameObject _rightHandController;

    [Header("Cameras in the main scenes")]
    /// <summary>
    /// First Person Camera
    /// </summary>
    [SerializeField] GameObject _fpCamera;
    /// <summary>
    /// Third Person Camera
    /// </summary>
    [SerializeField] GameObject _tpCamera;
    /// <summary>
    /// Front Camera
    /// </summary>
    [SerializeField] GameObject _frontCamera;


    [Header("Material useds for the sky in the different scenes")]
    /// <summary>
    /// Skybox
    /// </summary>
    [SerializeField] Material _skyboxWaitingMaterial;
    [SerializeField] Material _skyboxRoomMaterial;

    [Header("GameObject that manage loading between scenes")]
    [SerializeField] SceneLoaderController _sceneLoader;

    [Header("Hand buffers")]
    [SerializeField] InputBufferSO _leftBuffer;
    [SerializeField] InputBufferSO _rightBuffer;


    private SessionInfo _sessionInProgress;
    public SessionInfo SessionInProgress
    {
        get { return _sessionInProgress; }
    }

    private SessionLogger _sessionLogger;
    public SessionLogger SessionLogger
    {
        get { return _sessionLogger; }
    }


    // PRIVATE METHODS

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;

        InitApplication();
    }

    private void Update()
    {
    }

    private void InitApplication()
    {
        _sessionLogger = new();

        StartCoroutine(LoadAsyncScene(GameScene.ROOM_SCENE));
        //StartCoroutine(LoadAsyncScene(GameScene.WAIT_SCENE));
    }

    private void ResetCamerView()
    {
        WorldData.CameraView = WorldData.CameraViewType.FIRST;
        UpdateCameraView();
    }

    private void UpdateSkybox(SkyboxType type) { 
        switch(type)
        {
            case SkyboxType.WAITING:
                RenderSettings.skybox = _skyboxWaitingMaterial;
                break;

            case SkyboxType.ROOM:
                RenderSettings.skybox = _skyboxRoomMaterial;
                break;

            default: break;
        }
    
    }

    // PUBLIC METHODS


    public void UpdateCameraView()
    {
        if(WorldData.CameraView == WorldData.CameraViewType.FIRST)
        {
            _fpCamera.SetActive(true);
            _tpCamera.SetActive(false);
            _frontCamera.SetActive(false);
            return;
        }

        if (WorldData.CameraView == WorldData.CameraViewType.THIRD)
        {
            _fpCamera.SetActive(false);
            _tpCamera.SetActive(true);
            _frontCamera.SetActive(false);
            return;
        }

        if (WorldData.CameraView == WorldData.CameraViewType.FRONT)
        {
            _fpCamera.SetActive(false);
            _tpCamera.SetActive(false);
            _frontCamera.SetActive(true);
            return;
        }
    }

    public void LogChangeParams()
    {
        //_sessionLogger.LogWorldUpdate();
    }

    public void StartNewSession(StartSessionData data)
    {

        if(data.Blocks == null)
        {
            return;
        }

        _sessionInProgress = new()
        {
            Description = data.Description,
            Identifier = data.Identifier,
            Name = data.Name,
            CreatedAt = DateTime.Parse(data.CreatedAt),
            SessionBlocksList = new(data.Blocks),
        };
        _sessionLogger.LogInitSession();
        SessionManager.Instance.InitializeSession();
        
        //StartCoroutine(LoadAsyncScene(GameScene.ROOM_SCENE));
    }

    public void EndSession()
    {

        _settingsData.SessionEnable = false;
        _worldData.Delay = 0;

        if (_sessionInProgress != null )
        {
            StopHandLogging();
            _sessionLogger.LogEndSession();
            _sessionInProgress = null;
        }

       
        
        //StartCoroutine(LoadAsyncScene(GameScene.WAIT_SCENE));
    }

    public void EnableSession()
    {
        _settingsData.SessionEnable = true;
        StartHandLogging();
        
    }

    public void StartHandLogging()
    {
        //Check if already logging data
        if (_settingsData.LogsHand) return;
        /*
        _rightHandFollow = GameObject.FindGameObjectWithTag("RightFollowLog").transform;
        Debug.Log("StartHandLogging - 1");
        _leftHandFollow = GameObject.FindGameObjectWithTag("LeftFollowLog").transform;
        Debug.Log("StartHandLogging - 2");

        _rightHandReal = GameObject.FindGameObjectWithTag("RightOriginalLog").transform;
        Debug.Log("StartHandLogging - 3");
        _leftHandReal = GameObject.FindGameObjectWithTag("LeftOriginalLog").transform;
        Debug.Log("StartHandLogging - 4");

        if (_rightHandFollow != null && _rightHandReal != null && _leftHandFollow != null && _leftHandReal != null)
            Debug.Log("TUTTO A POSTO!!");
        else Debug.Log("QUALCHE MANO NULLLLLL");
        */

        _settingsData.LogsHand = true;
        _sessionLogger.StartHandLog();
        StartCoroutine(ReadInputValueCR());
    }

    public void StopHandLogging()
    {
        _settingsData.LogsHand = false;
        _sessionLogger.StopHandLog();
    }

    public void MoveCamera(CameraMovement movement)
    {
        if(movement == CameraMovement.UP)
        {
            _fpCamera.transform.Translate(new Vector3(0, 0.01f, 0));
            return;
        }

        if (movement == CameraMovement.DOWN)
        {
            _fpCamera.transform.Translate(new Vector3(0, -0.01f, 0));
            return;
        }

        if (movement == CameraMovement.RIGHT)
        {
            _fpCamera.transform.Translate(new Vector3(0.01f, 0, 0));
            return;
        }

        if (movement == CameraMovement.LEFT)
        {
            _fpCamera.transform.Translate(new Vector3(-0.01f, 0, 0));
            return;
        }

    }

    public void MoveButton(CameraMovement movement)
    {

        GameObject button = GameObject.FindGameObjectWithTag("Button");

        if (movement == CameraMovement.UP)
        {
            button.transform.Translate(new Vector3(-0.01f, 0, 0));
            return;
        }

        if (movement == CameraMovement.DOWN)
        {
            button.transform.Translate(new Vector3(0.01f, 0, 0));
            return;
        }

        if (movement == CameraMovement.RIGHT)
        {
            button.transform.Translate(new Vector3(0, 0, 0.01f));
            return;
        }

        if (movement == CameraMovement.LEFT)
        {
            button.transform.Translate(new Vector3(0, 0, -0.01f));
            return;
        }

    }

    public void MoveTable(TableMovement movement)
    {
        GameObject table = GameObject.FindGameObjectWithTag("Table");

        if(table == null) return;

        if (movement == TableMovement.FORWARD)
        {
            table.transform.Translate(new Vector3(0, 0, 0.01f));
            return;
        }

        if (movement == TableMovement.BACKWARD)
        {
            table.transform.Translate(new Vector3(0, 0, -0.01f));
            return;
        }
    }


    //CO-ROUTINES

    IEnumerator LoadAsyncScene(GameScene sceneToLoad)
    {

        _sceneLoader.StartLoading();

        yield return new WaitForSeconds(1f);

        string sceneName = string.Empty;
        string unloadName = string.Empty;

        switch (sceneToLoad)
        {
            case GameScene.WAIT_SCENE:
                UpdateSkybox(SkyboxType.WAITING);
                sceneName = "WaitingScene";
                unloadName = "SampleScene";
                break;
            case GameScene.ROOM_SCENE:
                UpdateSkybox(SkyboxType.ROOM);
                sceneName = "SampleScene";
                unloadName = "WaitingScene";
                break;
        }

        if(unloadName.Length > 0)
        {

            Scene sceneToUnLoad = SceneManager.GetSceneByName(unloadName);

            if (sceneToUnLoad.IsValid() && sceneToUnLoad.isLoaded)
            {
                AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(unloadName);
                while (!asyncUnload.isDone)
                    yield return null;
            }
        }

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        ResetCamerView();

        _sceneLoader.EndLoading();
        yield return new WaitForSeconds(1f);
    }

    IEnumerator ReadInputValueCR()
    {

        while (_settingsData.LogsHand)
        {
            //_sessionLogger.LogHandPosition(_leftHandReal.position, _leftHandFollow.position, _rightHandReal.position, _rightHandFollow.position);
            _sessionLogger.LogHandPosition(_leftBuffer.LastInputValue.position, _leftBuffer.LastReadedValue.position, _rightBuffer.LastInputValue.position, _rightBuffer.LastReadedValue.position);
            yield return new WaitForSeconds(_settingsData.LogHandSamplSeconds);
        }
    }

    //DEBUG
    public void DEBUG_AddToLog(string message)
    {
        _textLogger.text += "\n" + message;
    }

}