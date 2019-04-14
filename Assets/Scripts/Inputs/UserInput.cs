﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoHome
{
    public class UserInput : MonoBehaviour
    {
        public PlayerController controller;
        
        // Update is called once per frame
        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");
            controller.Move(inputH, inputV);
        }
    }
}