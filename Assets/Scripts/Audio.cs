using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
  [SerializeField] AudioSource SourceEffect;

  public void Start()
  {
    SourceEffect=GetComponent<AudioSource>();
    SourceEffect.Play();
  }
  public void StopSound()
  {
    SourceEffect.Stop();
  }


}
