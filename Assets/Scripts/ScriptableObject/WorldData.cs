using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This SO contains all the properties that define the world.
/// </summary>

[CreateAssetMenu(menuName = "WorldData")]
public class WorldData : ScriptableObject
{

    public const int FPS = 71;

    [SerializeField] private int _delay;
    public int Delay
    {
        get
        {
            return _delay;
        }
        set
        {
            if (value >= 0) _delay = value * FPS;
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

    /// <summary>
    /// Height of the table in centimeters
    /// </summary>
    [SerializeField] private int _tableHeight;
    public int TableHeight
    {
        get
        {
            return _tableHeight;
        }
        set
        {
            if(value < 0 || value > 80) _tableHeight = 80;
            else _tableHeight = value;
        }
    }

    private void OnEnable()
    {
        _delay = 0;
        _localMirror = false;
        _rotationMirror = false;
        _characterMirror = false;
        _thirdPerson = false;
        _tableHeight = 80;
    }

}