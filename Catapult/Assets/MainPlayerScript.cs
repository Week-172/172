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
            if(Input.GetKey("up"))
            rb2d.velocity=new Vector2(48.09083f, 20f);
            else if(Input.GetKey("down"))
            rb2d.velocity=new Vector2(48.09083f, -20f);
            else if(Input.GetKey("left"))
            rb2d.velocity=new Vector2(-DampAccn*48.09083f,rb2d.velocity.y);
            else if(Input.GetKey("right"))
            rb2d.velocity=new Vector2(BoostAccn*48.09083f,rb2d.velocity.y);
            else
            rb2d.velocity=new Vector2(48.09083f, 0f);

        }
    }
}
