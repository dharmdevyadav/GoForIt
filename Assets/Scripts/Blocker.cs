using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blocker : MonoBehaviour
{
  private GameManager ForScore;
  private void Start()
  {
    ForScore=FindObjectOfType<GameManager>();
  }

  public void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      ResetGame();
    }
  }
  public void ResetGame()
  {
    ForScore.ThemeSound.Stop();
    Destroy(gameObject);
    ForScore.GameOverPanel.SetActive(true);
    ForScore.CancelInvoke();
  }
  private void Update()
  {
    if (transform.position.y < -5.51f)
    {
      Destroy(gameObject);
    }
  }
}
