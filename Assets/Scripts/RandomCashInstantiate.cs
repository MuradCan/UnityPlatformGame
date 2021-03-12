using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCashInstantiate : MonoBehaviour
{
    
    public GameObject[] Cash;
    public float xPos;
    public float yPos;
    public float zPos;

    void Start () 
    {
        int randomIndex = Random.Range(0, Cash.Length);
        StartCoroutine(EnemyDrop());
    }
    
    IEnumerator EnemyDrop() 
    {
        
        yPos = Random.Range(-1f,2f);
        GameObject instantiatedObject = Instantiate(Cash[Random.Range(0,1)], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(8,15));
        StartCoroutine(EnemyDrop());
    }
}
