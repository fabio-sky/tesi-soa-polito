using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetTableDimensions();
    }

    void SetTableDimensions()
    {
        transform.position = new Vector3(transform.position.x, GameManager.Instance.WorldData.TableHeight / 100.0f, transform.position.z);
        transform.localScale = new Vector3(GameManager.Instance.WorldData.TableWidth / 100.0f, transform.localScale.y, GameManager.Instance.WorldData.TableDepth / 100.0f);
    }

    public void SetHeight()
    {
        SetTableDimensions();
    }
}
