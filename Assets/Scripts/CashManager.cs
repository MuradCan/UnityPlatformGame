using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashManager : MonoBehaviour
{
    Text text;
    public static int cash;
    
    // Start is called before the first frame update
    void Start()
    {
        text=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text=cash.ToString();
    }
    
}
