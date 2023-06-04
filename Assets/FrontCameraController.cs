using UnityEngine;

public class FrontCameraController : MonoBehaviour
{
    [SerializeField] Transform cameraRotationListener;

    void Start()
    {
        transform.position = cameraRotationListener.position;
    }

    void Update()
    {
        Vector3 localRotation = cameraRotationListener.rotation.eulerAngles;
        transform.localRotation = Quaternion.Euler(new Vector3(localRotation.x, -1 * localRotation.y + 90, localRotation.z));
    }
}
