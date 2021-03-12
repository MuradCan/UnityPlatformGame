using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashScript : MonoBehaviour

{
    public AudioSource cash;
    void OnTriggerEnter2D(Collider2D col) 
    {
      
        CashManager.cash+=3;
        gameObject.GetComponent<SpriteRenderer>().enabled=false;
        cash.Play();
        StartCoroutine(WaitDestroy());

        
    }

    IEnumerator WaitDestroy()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
