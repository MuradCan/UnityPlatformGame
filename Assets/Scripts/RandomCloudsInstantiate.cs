using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloudsInstantiate : MonoBehaviour
{
    
    public GameObject[] Clouds;
    public float xPos;
    public float yPos;
    public float zPos;
    public float BuildingTime=2f;

    void Start () 
    {
        int randomIndex = Random.Range(0, Clouds.Length);
        StartCoroutine(EnemyDrop());
    }
    
    

    IEnumerator EnemyDrop() 
    {
      
        yPos = Random.Range(1.3f,4.3f);
        
        GameObject instantiatedObject = Instantiate(Clouds[Random.Range(0,5)], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        yield return new WaitForSeconds(BuildingTime);
        StartCoroutine(EnemyDrop());
    }
}
