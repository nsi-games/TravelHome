using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
  public bool destroySelf = false;
  public UnityEvent onEnter;

  // Runs when Other Object Intersects GameObject
  public void OnTriggerEnter(Collider other)
  {
    // If we collide with the Player
    if (other.tag == "Player")
    {
      // Run all specified events
      onEnter.Invoke();
      // Destroy self?
      if (destroySelf)
      {
        // Destroy GameObject script is attached to
        Destroy(gameObject);
      }
    }
  }
}
