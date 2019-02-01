using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    public Vector3 idleScale;
    public Vector3 pressedScale;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            transform.localScale = pressedScale;
        }
        else
        {
            transform.localScale = idleScale;
        }
    }
}
