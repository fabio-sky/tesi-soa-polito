using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broadcaster : MonoBehaviour
{
    [SerializeField] GameEventChannel onServerEvent;

    public void BroadcastEvent()
    {
        onServerEvent.Raise();
    }
}
