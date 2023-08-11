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

    [SerializeField] private CameraViewType _cameraView;
    public CameraViewType CameraView
    {
        get
        {
            return _cameraView;
        }
        set
        {
            _cameraView = value;
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
            if(value < 0) _tableHeight = 100;
            else _tableHeight = value;
        }
    }

    /// <summary>
    /// Width of the table in centimeters
    /// </summary>
    [SerializeField] private int _tableWidth;
    public int TableWidth
    {
        get
        {
            return _tableWidth;
        }
        set
        {
            if (value < 0) _tableWidth = 100;
            else _tableWidth = value;
        }
    }

    /// <summary>
    /// Depth of the table in centimeters
    /// </summary>
    [SerializeField] private int _tableDepth;
    public int TableDepth
    {
        get
        {
            return _tableDepth;
        }
        set
        {
            if (value < 0) _tableDepth = 100;
            else _tableDepth = value;
        }
    }

    /// <summary>
    /// Horizontal Position of the button
    /// </summary>
    [SerializeField] private int _buttonHorizontal;
    public int ButtonHorizontal
    {
        get
        {
            return _buttonHorizontal;
        }
        set
        {
            _buttonHorizontal = value;
        }
    }

    /// <summary>
    /// Vertical Position of the button
    /// </summary>
    [SerializeField] private int _buttonVertical;
    public int ButtonVertical
    {
        get
        {
            return _buttonVertical;
        }
        set
        {
            _buttonVertical = value;
        }
    }

    private void OnEnable()
    {
        _delay = 0;
        _localMirror = false;
        _rotationMirror = false;
        _characterMirror = false;
        _cameraView = CameraViewType.FIRST;
        _tableHeight = 80;
    }

    public string Log()
    {
        return JsonUtility.ToJson(this);
    }

    public enum CameraViewType
    {
        FIRST,
        THIRD,
        FRONT
    }
}