using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManager : MonoBehaviour
{
  [Header("Main Screens")]
  [SerializeField] private GameObject LoadingScreen;
  [SerializeField] private GameObject MainMenu;

  [Header("Slider")]
  [SerializeField] private Slider LoadingBar;

  public void LoadingLevelBtn(string LevelToLoad)
  {
    MainMenu.SetActive(false);
    LoadingScreen.SetActive(true);
    StartCoroutine(Loading(LevelToLoad));
  }

  IEnumerator Loading(string LevelToLoad)
  {
    AsyncOperation Loadoperation = SceneManager.LoadSceneAsync(LevelToLoad);
    while (!Loadoperation.isDone)
    {
      float ProgressValue = Mathf.Clamp01(Loadoperation.progress / 0.9f);
      LoadingBar.value = ProgressValue;
      yield return null;
    }
  }
}
