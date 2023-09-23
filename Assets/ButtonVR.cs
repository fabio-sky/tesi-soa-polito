using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    [SerializeField] GameObject button;

    GameObject presser;
    bool isPressed;
    AudioSource _audio;

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("OnTriggerEnter");

        if (!isPressed)
        {
            //HandleOnPress();
            button.transform.localPosition = new Vector3(0, -0.005f, 0);
            presser = other.gameObject;
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        Debug.Log("OnTriggerExit");

        if (isPressed && other.gameObject.name == presser.name)
        {
            //HandleOnRelease();
            button.transform.localPosition = new Vector3(0, 0, 0);
            isPressed = false;
        }
    }

    public void HandleOnPress()
    {
        _audio.Play();
        SessionManager.Instance.ButtonPress();
    }
    public void HandleOnRelease()
    {
        SessionManager.Instance.ButtonRelease();
        
    }

}
