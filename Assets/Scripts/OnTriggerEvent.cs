using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
  public bool destroySelf = false;
  public UnityEvent onEnter;

  public void OnTriggerEnter(Collider other)
  {
    // Check if we hit the Player
    if(other.tag == "Player")
    {
      // Run all specified events
      onEnter.Invoke();
      // If 'DestroySelf' is ticked
      if(destroySelf)
      {

        // Destroy GameObject
        Destroy(gameObject);
        // Destroy the other GameObject
        //Destroy(other.gameObject);
      }
    }
  }
}
