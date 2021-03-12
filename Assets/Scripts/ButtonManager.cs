using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void PlayAgain()
    {
        StartCoroutine(PlayWait());
    }

    IEnumerator PlayWait()
    {
        yield return new WaitForSeconds (0.5f);
        SceneManager.LoadScene("Game");
    }

}
