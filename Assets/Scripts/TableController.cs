using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHeight()
    {
        transform.position = new Vector3(transform.position.x, GameManager.Instance.WorldData.TableHeight / 100.0f, transform.position.z);
    }
}
