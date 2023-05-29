using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SettingsData")]
public class SettingsData : ScriptableObject
{
    [SerializeField] private int _positionSampleMilliseconds;
    public int PositionSampleMilliseconds
    {
        get
        {
            return _positionSampleMilliseconds;
        }
        set
        {
            if (value >= 0) _positionSampleMilliseconds = value;
            else _positionSampleMilliseconds = 0;

        }
    }
    public float PositionSampleSeconds
    {
        get
        {
            return _positionSampleMilliseconds / 1000.0f;
        }
    }

    [SerializeField] private int _logHandSampleMilliseconds;
    public int LogHandSampleMilliseconds
    {
        get
        {
            return _logHandSampleMilliseconds;
        }
        set
        {
            if (value >= 0) _logHandSampleMilliseconds = value;
            else _logHandSampleMilliseconds = 0;

        }
    }
    public float LogHandSamplSeconds
    {
        get
        {
            return _logHandSampleMilliseconds / 1000.0f;
        }
    }

    [SerializeField] private bool _logHands;
    public bool LogsHand
    {
        get
        {
            return _logHands;
        }
        set
        {
            _logHands = value;

        }
    }

    private void OnEnable()
    {
        _logHandSampleMilliseconds = 500;
        _positionSampleMilliseconds = 30;
    }
}
