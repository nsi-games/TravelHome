using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnGoal : MonoBehaviour
{
    public string hitTag = "";
    [Space]
    public UnityEvent onGoal;

    private void OnTriggerEnter(Collider other)
    {
        if (hitTag == other.tag || hitTag == "")
        {
            onGoal.Invoke();
        }
    }
}