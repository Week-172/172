using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flytime : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }
    void OnTriggerExit(Collision col)
    {
        if(col.gameObject.CompareTag("FlyTrigger"))
        {
            anim.Play("BoiFlies");
            rb2d.bodyType=RigidbodyType2D.Kinematic;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
