using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
  public void ScenePlay()
  {
    SceneManager.LoadScene("Playing");
  }
  public void SceneOptions()
  {
      SceneManager.LoadScene("Options");
  }
  public void SceneHistory()
  {
    SceneManager.LoadScene("History");
  }
  public void ExitGame()
  {
    Debug.Log("quit");
    Application.Quit();
  }
}
