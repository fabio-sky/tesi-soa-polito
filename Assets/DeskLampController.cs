using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskLampController : MonoBehaviour
{

    [SerializeField] Light _light;
    [SerializeField] Transform _referencePoint;

    bool _lastValue = false;

    // Update is called once per frame
    void Update()
    {

        transform.position = _referencePoint.position;

        bool value = GameManager.Instance.SettingsData.SessionEnable;

        if(value != _lastValue)
        {
            _lastValue = value;
            _light.color = value ? Color.green : Color.red;
        }
    }
}
