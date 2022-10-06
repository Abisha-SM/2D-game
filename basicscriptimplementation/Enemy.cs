using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public  abstract class Enemy :MonoBehaviour
    {
    public GameObject enemy;
    public Rigidbody2D rb;

    
    //public abstract void OnCollisionEnter(Collision collision);

    public abstract void FixedUpdate();
    public  void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.velocity = new Vector2(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.velocity = new Vector2(1, 0);
        }
    }



}










