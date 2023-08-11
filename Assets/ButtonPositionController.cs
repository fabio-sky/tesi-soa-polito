using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPositionController : MonoBehaviour
{

    [SerializeField] Transform referencePoint;
    void Start()
    {
        transform.position = referencePoint.position;
    }

    public void UpdatePosition()
    {
        transform.position = new Vector3(referencePoint.position.x - GameManager.Instance.WorldData.ButtonHorizontal / 100.0f, referencePoint.position.y, referencePoint.position.z + GameManager.Instance.WorldData.ButtonVertical / 100.0f);
    }
}
