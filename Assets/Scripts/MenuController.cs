using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] Animator _menuAnimator;

    private bool _menuIsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ManageMenu()
    {
        if(_menuIsOpen)
        {
            CloseMenu();
        }
        else OpenMenu();
    }

    public void OpenMenu()
    {
        _menuAnimator.SetBool("open", true);
        _menuIsOpen = true;
        Debug.Log("OPEN MENU");
    }

    public void CloseMenu()
    {
        _menuAnimator.SetBool("open", false);
        _menuIsOpen = false;
        Debug.Log("CLOSE MENU");
    }
}
