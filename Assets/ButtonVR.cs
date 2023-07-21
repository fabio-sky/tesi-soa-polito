using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] UnityEvent onPress;
    [SerializeField] UnityEvent onRelease;

    [SerializeField] AudioClip buttonPress;
    [SerializeField] AudioClip buttonRelease;

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
            button.transform.localPosition = new Vector3(0, -0.005f, 0);
            presser = other.gameObject;
            onPress.Invoke();

            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {

        Debug.Log("OnTriggerExit");

        if (isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void HandleOnPress()
    {
        _audio.clip = buttonPress;
        _audio.Play();
    }
    public void HandleOnRelease()
    {
        _audio.clip = buttonRelease;
        _audio.Play();
    }

}
