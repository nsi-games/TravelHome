﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public Camera attachedCamera;
    public float minYAngle = 30f, maxYAngle = 90f;
    public float ySpeed = 120f, xSpeed = 120f;

    void Start()
    {
        Rotate();        
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Rotate();
        }
    }

    void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 euler = transform.eulerAngles;
        euler.x -= mouseY * ySpeed * Time.deltaTime;
        euler.y += mouseX * xSpeed * Time.deltaTime;
        euler.x = Mathf.Clamp(euler.x, minYAngle, maxYAngle);
        transform.eulerAngles = euler;
    }
}
