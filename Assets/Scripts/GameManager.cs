using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] WorldData _worldData;
    public WorldData WorldData
    {
        get
        {
            return _worldData;
        }
    }

    [SerializeField] GameObject _leftHandController;
    [SerializeField] GameObject _rightHandController;

    /// <summary>
    /// First Person Camera
    /// </summary>
    [SerializeField] GameObject _fpCamera;
    /// <summary>
    /// Third Person Camera
    /// </summary>
    [SerializeField] GameObject _tpCamera;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            _fpCamera.SetActive(false);
            _tpCamera.SetActive(true);
        }
        else if(Input.GetKey(KeyCode.F)) {
            _fpCamera.SetActive(true);
            _tpCamera.SetActive(false);
        }
    }

    private void HandleThirdPerson()
    {
        if (_worldData.ThirdPerson)
        {
            _fpCamera.SetActive(false);
            _tpCamera.SetActive(true);
        }
        else
        {
            _fpCamera.SetActive(true);
            _tpCamera.SetActive(false);
        }
    }

    public void HandleChangeParameters()
    {
        HandleThirdPerson();
    }
}
