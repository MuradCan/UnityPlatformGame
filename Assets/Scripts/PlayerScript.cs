using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpSpeed = 10f;
    public int jumpCount=2;
    public static bool GameOver;
    public AudioSource jump;
    

    void Start() 
    {
        GameOver=false;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale=0.5f;
        StartCoroutine(GeriSayim());
        
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if(Input.GetMouseButtonDown(0) && jumpCount>0 ||Input.GetButtonDown("Jump")  && jumpCount>0)
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            rb.velocity += jumpVelocityToAdd;
            jumpCount--;
            jumpSpeed-=2;
            jump.Play();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Building")
        {
            jumpCount=2;
            jumpSpeed = 10f;
            
            
        }
        if(collision.gameObject.tag == "Block")
        {
            StartCoroutine(GameOverWait());
        }
       
        
    }

    IEnumerator GameOverWait()
    {
        yield return new WaitForSeconds(0.1f);
        GameOver=true;
    }
IEnumerator GeriSayim()
    {
        yield return new WaitForSeconds(1);
        rb.gravityScale=3;
    }


}
