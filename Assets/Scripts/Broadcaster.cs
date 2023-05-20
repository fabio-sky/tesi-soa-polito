using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broadcaster : MonoBehaviour
{
    [SerializeField] GameEventChannel onServerEvent;
    [SerializeField] GameEventChannel onAudioEvent;

    public void BroadcastEvent()
    {
        onServerEvent.Raise();
    }

    public void BroadcastAudioEvent()
    {
        onAudioEvent.Raise();
    }
}
