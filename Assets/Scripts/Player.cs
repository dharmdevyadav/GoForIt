using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField] float moveSpeed;
  Rigidbody2D rb;
  public bool isStarted;
  //[SerializeField] AudioSource ThemeSound;
  Audio StartSound;
  // Start is called before the first frame update
  void Start()
  {
   // ThemeSound=GetComponent<AudioSource>();
    rb = GetComponent<Rigidbody2D>();
    StartSound = FindObjectOfType<Audio>();
    isStarted = false;
   // ThemeSound.Stop();
  }

  // Update is called once per frame
  void Update()
  {
    //For Desktop Play mode
    /*float XInput = Input.GetAxisRaw("Horizontal");
    rb.velocity = new Vector2(XInput*moveSpeed*Time.deltaTime, rb.velocity.y);*/
    //For Android Device Play Mode
    if (Input.GetMouseButtonDown(0))
    {
      isStarted = true;
      //ThemeSound.Play();
      StartSound.StopSound();
      Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      if (touchPos.x > 0)
      {
        rb.AddForce(Vector2.right * moveSpeed);
      }
      else
      {
        rb.AddForce(Vector2.left * moveSpeed);
      }
    }
    else
    {
      rb.velocity = Vector3.zero;
    }

  }
}
