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
}
