using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBuildingsInstantiate : MonoBehaviour
{
    
    public GameObject[] Buildings;
    public float xPos;
    public float yPos;
    public float zPos;
    public float BuildingTime=0.65f;

    void Start () 
    {
        int randomIndex = Random.Range(0, Buildings.Length);
        StartCoroutine(EnemyDrop());
    }
    
    void Update()
    {
        if(BuildingTime<=1.5f)
        BuildingTime+=0.0001f;
        else
        BuildingTime=1.5f;
    }

    IEnumerator EnemyDrop() 
    {
        xPos = Random.Range(12f,12.6f);
        yPos = Random.Range(-6f,-2f);
        GameObject instantiatedObject = Instantiate(Buildings[Random.Range(0,4)], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        yield return new WaitForSeconds(BuildingTime);
        StartCoroutine(EnemyDrop());
    }
}
