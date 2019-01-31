using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            transform.localScale = new Vector3(1.1f, 1.1f, 0.1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 0.1f);
        }
    }
}
