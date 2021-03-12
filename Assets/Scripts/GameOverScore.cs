using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    Text GameOverScoreText;
   
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverScoreText=GetComponent<Text>();
        StartCoroutine(ScoreArtır());
         
    }

    // Update is called once per frame
    void Update()
    {   
       
        GameOverScoreText.text=ScoreManager.score.ToString();
        
    }

    IEnumerator ScoreArtır()
    {
        while(PlayerScript.GameOver==false)
        {
        ScoreManager.score+=10;
        yield return new WaitForSeconds(1);
        }
    }
}
