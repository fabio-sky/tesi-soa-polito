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
    [SerializeField] GameObject _invertedLeftHandController;
    [SerializeField] GameObject _invertedRightHandController;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;
    }

    public void ReceiveData()
    {
        Debug.Log("EVENTO RICEVUTO");
        _worldData.Delay += 10;
    }

    public void ManageCharacterMirror()
    {
        if (WorldData.CharacterMirror) {
            _invertedLeftHandController.SetActive(true);
            _invertedRightHandController.SetActive(true);
            _leftHandController.SetActive(false);
            _rightHandController.SetActive(false);
        }
        else {
            _invertedLeftHandController.SetActive(false);
            _invertedRightHandController.SetActive(false);
            _leftHandController.SetActive(true);
            _rightHandController.SetActive(true);
        }
    }
}
