using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endscreen : MonoBehaviour
{
  public void RestartGame()
  {
    SceneManager.LoadScene("Game");
  }
  public void QuitGame()
  {
    Application.Quit();
    Debug.Log("Exited SuccuessFully!!");
  }
}
