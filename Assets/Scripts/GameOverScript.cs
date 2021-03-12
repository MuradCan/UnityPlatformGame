using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{

    
    public GameObject GameOverPanel;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(false);
        PlayerScript.GameOver=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.GameOver==true)
        {
        GameOverPanel.SetActive(true);
        Time.timeScale=0;
        player.SetActive(false);
        }
        else
        GameOverPanel.SetActive(false);
        Time.timeScale=1;
    }

    
}
