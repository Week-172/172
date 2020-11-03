using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour
{
    public float length, startpos;

    [SerializeField]
    GameObject Infiniter;
    [SerializeField]
    GameObject Player;
    // Start is called before the first frame updates 
    void Start()
    {
        length=GetComponent<SpriteRenderer>().bounds.size.x;
    }
    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x - Infiniter.transform.position.x >= length)
        Infiniter.transform.position = new Vector2(Player.transform.position.x, Infiniter.transform.position.y);       
    }
};
