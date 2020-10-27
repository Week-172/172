using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamestart : MonoBehaviour
{
    
    [SerializeField]
    float LaunchSpeed;
    // Start is called before the first frame update
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("right"))
        {
        GetComponent<Rigidbody2D>().AddTorque(LaunchSpeed);
        }    
    }
}
