using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("right"))
        {
        GetComponent<Rigidbody2D>().angularVelocity = -2500;
        }    
    }
}
