using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InputBuffer")]
public class InputBufferSO : ScriptableObject
{
    private List<InputData> _buffer;
    public int _readCounter;
    public int _writeCounter;
    private InputData _emptyValue;

    [SerializeField] WorldData _worldData;


    private InputData _lastReadedValue;
    public InputData LastReadedValue
    {
        get
        {
            return _lastReadedValue;
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

    public InputData GetValue()
    {
        InputData readedData = _buffer[_readCounter];
        return readedData;
    }

    public InputData ReadThenAddValue(InputData input)
    {

        int delay = _worldData.Delay;

        if (_buffer.Count > delay)
        {
            Clear();
            return _emptyValue;
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
