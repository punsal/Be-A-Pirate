using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAidedRotator : MonoBehaviour
{
    public float rotationSpeed = 10f;

    private Camera cam; //Main Camera

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Rotator();
        }
    }

    private void Rotator_X()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = cam.transform.position.y - transform.position.y;

        Vector3 mouseWorldPos = cam.ScreenToWorldPoint(mousePos);

        float angle = -Mathf.Atan2(transform.position.z - mouseWorldPos.z,
            transform.position.x - mouseWorldPos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Slerp(transform.rotation,
            Quaternion.Euler(0, angle, 0),
            rotationSpeed * Time.deltaTime);
    }

    private void Rotator()
    {
        Vector3 mousePosition = Input.mousePosition;


    }
}
