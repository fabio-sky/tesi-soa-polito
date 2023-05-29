using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderController : MonoBehaviour
{
    [SerializeField] Animator _animator;

    public void StartLoading()
    {
        if(_animator != null)
        {
            _animator.SetBool("show", true);
        }
    }

    public void EndLoading()
    {
        if (_animator != null)
        {
            _animator.SetBool("show", false);
        }
    }
}
