using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contains data relative to a block on the session
/// </summary>
public record SessionBlock
{
    public string id;
    public int numberOfTry;
    public int restTime;
    public int delay;
    public TargetBehaviour target;
    public bool localMirror;
    public bool characterMirror;
    public bool thirdPersonView;


    public enum TargetBehaviour
    {
        FIXED,
        RANDOM,
    }
}
