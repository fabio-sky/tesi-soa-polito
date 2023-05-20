using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffectsController : MonoBehaviour
{

    AudioSource _audio = null;

    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReproduceAudio()
    {
        if(_audio != null )
        {
            _audio.Play();
        }
    }
}
