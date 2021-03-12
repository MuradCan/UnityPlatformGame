using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text scoreText;
    public static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText=GetComponent<Text>();
        StartCoroutine(ScoreArtır());
         score=0;
    }

    // Update is called once per frame
    void Update()
    {   
       
        scoreText.text=score.ToString();
        
    }

    IEnumerator ScoreArtır()
    {
        while(PlayerScript.GameOver==false)
        {
        score+=10;
        yield return new WaitForSeconds(1);
        }
    }

}
