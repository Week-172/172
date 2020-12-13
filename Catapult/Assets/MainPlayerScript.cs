using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerScript : MonoBehaviour
{
    [SerializeField]
    float BoostAccn;
    [SerializeField]
    float DampAccn;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
        void Update()
    {
        if(rb2d.bodyType==RigidbodyType2D.Kinematic)
        {
            var newV = new Vector2( 48.09083f, 0f);
            
            if(Input.GetKey("up"))
                newV.y = 20f;
            else if(Input.GetKey("down"))
                newV.y = -20f;

            if(Input.GetKey("left"))
                newV.x *= -DampAccn;
            else if(Input.GetKey("right"))
                newV.x *= BoostAccn;
            
            rb2d.velocity=newV;
        }
    }
}
