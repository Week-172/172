using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flytime : MonoBehaviour
{
    GameObject Pilot;
    Animator anima;
    Rigidbody2D rb2d;
    [SerializeField]
    Transform BackLimit;
    [SerializeField]
    Transform FrontLimit;

    // Start is called before the first frame update
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        anima=GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("FlyTrigger"))
        {
            anima.SetBool("EnterFlyZone",true);
            rb2d.bodyType=RigidbodyType2D.Kinematic;
        }
        if(anima.GetBool("EnterFlyZone"))
        {
            anima.Play("BoiFlies");
            rb2d.freezeRotation=true;
            rb2d.velocity=new Vector2(rb2d.velocity.x,0);
            rb2d.isKinematic=true;
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<BackLimit.position.x)
        transform.position=new Vector2(BackLimit.position.x,transform.position.y);
        if(transform.position.x>FrontLimit.position.x)
        transform.position=new Vector2(FrontLimit.position.x,transform.position.y);
    }
}
