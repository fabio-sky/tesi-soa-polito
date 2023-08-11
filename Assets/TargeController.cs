using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargeController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SessionManager.Instance.TargetReached();

        Destroy(gameObject);
    }
}
