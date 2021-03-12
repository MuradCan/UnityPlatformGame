using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xmove : MonoBehaviour
{
   
   public float xSpeed;

    void Update()
    {
        transform.position += new Vector3 (-xSpeed, 0, 0);
    }
}
