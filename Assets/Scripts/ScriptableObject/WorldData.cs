using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This SO contains all the properties that define the world.
/// </summary>

[CreateAssetMenu(menuName = "WorldData")]
public class WorldData : ScriptableObject
{
    [SerializeField] private int _delay;
    public int Delay
    {
        get
        {
            return _delay;
        }
        set {
            if (value >= 0) _delay = value;
            else _delay = 0;
        }
    }

    private void OnEnable()
    {
        _delay = 0;
    }
}
