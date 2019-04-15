using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Camera attachedCamera;
    public float minYAngle = 30f, maxYAngle = 90f;
    public float ySpeed = 120f, xSpeed = 120f;

    private Vector3 euler;

    void Start()
    {
        euler = transform.eulerAngles;
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            euler.x -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
            euler.y += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
            euler.x = Mathf.Clamp(euler.x, minYAngle, maxYAngle);
            transform.eulerAngles = euler;
        }
    }
}
