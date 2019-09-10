using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public void NextLevel()
  {
    // Get current scene
    Scene currentScene = SceneManager.GetActiveScene();
    // Load next scene
    SceneManager.LoadScene(currentScene.buildIndex + 1);
  }
}
