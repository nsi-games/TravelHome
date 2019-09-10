using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public void NextLevel()
  {
    // Get Current Scene
    Scene currentScene = SceneManager.GetActiveScene();
    // Load Next Scene
    SceneManager.LoadScene(currentScene.buildIndex + 1);
  }
}
