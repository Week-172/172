using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixing : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField]
    Rigidbody2D MC; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(MC.isKinematic)
        rigidbody2D.velocity = new Vector2(48.20083f,0f);
    }
}
