using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionInProgressWarning : MonoBehaviour
{
    [SerializeField] Transform _referencePoint;
    [SerializeField] GameObject _label;

    bool _lastValue = false;

    private void Start()
    {
        _label.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = _referencePoint.position;

        bool value = GameManager.Instance.SettingsData.SessionEnable;

        if (value != _lastValue)
        {
            _lastValue = value;
            _label.SetActive(value);
        }
    }
}
