using System;
using System.Collections;
using System.Collections.Generic;
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
    public SettingsData SettingsData
    {
        get
        {
            return _settingsData;
        }
    }

    [Header("Real tracked hand and follow hand needed to log positions")]
    [SerializeField] Transform _rightHandReal;
    [SerializeField] Transform _rightHandFollow;

    [SerializeField] Transform _leftHandReal;
    [SerializeField] Transform _leftHandFollow;

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
        StartCoroutine(LoadAsyncScene(GameScene.WAIT_SCENE));
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
        _sessionLogger.LogWorldUpdate();
    }

    public void StartNewSession(StartSessionData data) {
        
        _sessionInProgress = new() { Description = data.Description, Identifier = data.Identifier, Name = data.Name, CreatedAt = DateTime.Parse(data.CreatedAt) };
        _sessionLogger.LogInitSession();

        StartCoroutine(LoadAsyncScene(GameScene.ROOM_SCENE));
    }

    public void EndSession()
    {
        _sessionLogger.LogEndSession();
        _sessionInProgress = null;
        StartCoroutine(LoadAsyncScene(GameScene.WAIT_SCENE));
    }

    public void StartHandLogging()
    {
        _settingsData.LogsHand = true;
        _sessionLogger.StartHandLog();
        StartCoroutine(ReadInputValueCR());
    }

    public void StopHandLogging()
    {
        _settingsData.LogsHand = false;
        _sessionLogger.StopHandLog();
    }

    public void MoveCamera(string movement)
    {
        if(movement == "UP")
        {
            _fpCamera.transform.Translate(new Vector3(0, 0.01f, 0));
            return;
        }

        if (movement == "DOWN")
        {
            _fpCamera.transform.Translate(new Vector3(0, -0.01f, 0));
            return;
        }

        if (movement == "RIGHT")
        {
            _fpCamera.transform.Translate(new Vector3(0.01f, 0, 0));
            return;
        }

        if (movement == "LEFT")
        {
            _fpCamera.transform.Translate(new Vector3(-0.01f, 0, 0));
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

        _sceneLoader.EndLoading();
        yield return new WaitForSeconds(1f);
    }

    IEnumerator ReadInputValueCR()
    {

        while (_settingsData.LogsHand)
        {
            _sessionLogger.LogHandPosition(_leftHandReal.position, _leftHandFollow.position, _rightHandReal.position, _rightHandFollow.position);
            yield return new WaitForSeconds(_settingsData.LogHandSamplSeconds);
        }
    }
}