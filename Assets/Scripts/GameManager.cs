using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
  public GameObject Blocks;
  public GameObject NewBlock;
  public GameObject NewBlock2;
  [SerializeField] Transform SpawnPoint;
  [SerializeField] GameObject TapStart;
  [SerializeField] TextMeshProUGUI scoreText;
  [SerializeField] TextMeshProUGUI FinalScoreText;
  public AudioSource ThemeSound;
  public GameObject GameOverPanel;
  public GameObject Scorepanel;
  public float xMin =-1.80f;
  public float xMax=2.32f;
  public float spawnRate = 1.15f;
  public float spawnRate1 = 0.90f;
  public float spawnRate2 = 0.75f;
  bool isGameStarted;
  int Score = 0;

  private void Start()
  {
    TapStart.SetActive(true);
    isGameStarted = false;
  }
  void Update()
    {
    
    if (Input.GetMouseButton(0)&&!isGameStarted)
    {
      Scorepanel.SetActive(true);
      TapStart.SetActive(false);
      isGameStarted = true;
      SpawnCall();
           
    }
    }
  public void SpawnCall()
  {
    ThemeSound.Play();
    {
      InvokeRepeating(nameof(spawnPos), 2.5f, spawnRate);
    }
    
  }
  public void spawnPos()
  {
    Vector2 spawnpos = SpawnPoint.position;
    spawnpos.x = Random.Range(xMin, xMax);
    Instantiate(Blocks, spawnpos, Quaternion.identity);
    Score++;
    scoreText.text = Score.ToString();
    if (Score >= 60&&Score<=130)
    {
      CancelInvoke();
      InvokeRepeating(nameof(spawnPosForNew), 2.5f, spawnRate1);
    }
    FinalScoreText.text = Score.ToString();
 }
  public void spawnPosForNew()
  {
    Vector2 spawnpos1 = SpawnPoint.position;
    spawnpos1.x = Random.Range(xMin, xMax);
    Instantiate(NewBlock, spawnpos1, Quaternion.identity);
    Score++;
    scoreText.text = Score.ToString();
    if (Score >130)
    {
      CancelInvoke();
      InvokeRepeating(nameof(spawnPosForNew2), 2.5f, spawnRate2);
    }
    FinalScoreText.text = Score.ToString();

  }
  public void spawnPosForNew2()
  {
    Vector2 spawnpos2 = SpawnPoint.position;
    spawnpos2.x = Random.Range(xMin, xMax);
    Instantiate(NewBlock2, spawnpos2, Quaternion.identity);
    Score++;
    scoreText.text = Score.ToString();
    FinalScoreText.text = Score.ToString();

  }
}
