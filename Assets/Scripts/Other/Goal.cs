﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GoHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onGoal;

        private void OnTriggerEnter(Collider other)
        {
            onGoal.Invoke();
        }
    }
}