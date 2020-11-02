using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerScript : MonoBehaviour
{
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
            if(Input.GetKey("up"))
            rb2d.velocity=new Vector2(rb2d.velocity.x, 20f);
            else if(Input.GetKey("down"))
            rb2d.velocity=new Vector2(rb2d.velocity.x, -20f);
            else
            rb2d.velocity=new Vector2(rb2d.velocity.x, 0f);

        }
    }
}
