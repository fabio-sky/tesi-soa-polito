using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InputBuffer")]
public class InputBufferSO : ScriptableObject
{
    #region Buffer
    private List<InputData> _buffer;
    public int _readCounter;
    public int _writeCounter;
    private InputData _emptyValue;
    #endregion

    /// <summary>
    /// Discrete Data readed from the buffer
    /// </summary>
    #region Discrete input data
    private Vector3 _lastMovement;
    public Vector3 LastMovement
    {
        get
        {
            return _lastMovement;
        }
        set { _lastMovement = value; }
    }

    private Quaternion _lastRotation;
    public Quaternion LastRotation
    {
        get
        {
            return _lastRotation;
        }
        set { _lastRotation = value; }
    }
    #endregion


    [SerializeField] WorldData _worldData;


    private InputData _lastReadedValue;
    public InputData LastReadedValue
    {
        get
        {
            return _lastReadedValue;
        }
    }

    private InputData _lastInputValue;
    public InputData LastInputValue
    {
        get
        {
            return _lastInputValue;
        }
    }


    private void Clear() { _buffer.Clear(); }

    public void Init()
    {
        _readCounter = 0;
        _writeCounter = 0;
        _buffer = new();

        _emptyValue = new()
        {
            isEmpty = true
        };
    }


    public InputData ReadThenAddValue(InputData input)
    {

        int delay = _worldData.Delay;
        _lastInputValue = input;

        if(delay == 0)
        {
            _lastReadedValue = input;
            return input;
        }

        if (_buffer.Count > delay)
        {
            Clear();
            return _lastInputValue;
        }


        if (_buffer.Count < delay)
        {
            _buffer.Add(input);
            return _emptyValue;
        }

        _readCounter++;
        if (_readCounter >= delay)
            _readCounter = 0;

        InputData readedData = _buffer[_readCounter];
        _lastReadedValue = readedData;

        _writeCounter++;
        if (_writeCounter >= delay)
            _writeCounter = 0;
        _buffer[_writeCounter] = input;

        return readedData;

    }

}
