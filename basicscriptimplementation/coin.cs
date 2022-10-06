using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : Enemy
{
    public GameObject Coin;
    
    public Transform coinpoint;
    public float rotatespeed = 5f;
    void Start()
    {
        //InvokeRepeating("spawncoin", 1f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  override void FixedUpdate()
    {
        transform.Rotate(Vector3.up, rotatespeed);
       
       
    }
   /* void spawncoin()
    {
        Instantiate(Coin, coinpoint.position, Quaternion.identity);
    }*/
}
