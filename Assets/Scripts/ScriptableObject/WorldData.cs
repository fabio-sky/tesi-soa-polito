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
        set
        {
            if (value >= 0) _delay = value;
            else _delay = 0;
        }
    }


    [SerializeField] private bool _localMirror;
    public bool LocalMirror
    {
        get
        {
            return _localMirror;
        }
        set
        {
            _localMirror = value;
        }
    }

    [SerializeField] private bool _rotationMirror;
    public bool RotationMirror
    {
        get
        {
            return _rotationMirror;
        }
        set
        {
            _rotationMirror = value;
        }
    }


    [SerializeField] private bool _characterMirror;
    public bool CharacterMirror
    {
        get
        {
            return _characterMirror;
        }
        set
        {
            _characterMirror = value;
        }
    }

    [SerializeField] private bool _thirdPerson;
    public bool ThirdPerson
    {
        get
        {
            return _thirdPerson;
        }
        set
        {
            _thirdPerson = value;
        }
    }

    private void OnEnable()
    {
        _delay = 0;
        _localMirror = false;
        _rotationMirror = false;
        _characterMirror = false;
        _thirdPerson = false;
    }

}