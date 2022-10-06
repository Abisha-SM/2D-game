using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Girlplayer : MonoBehaviour
{

    Rigidbody rb;
    float xInput;
    float zInput;
    public float movespeed;
    //public GameObject text;
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        float xvelocity = xInput * movespeed;
        float zvelocity = zInput * movespeed;
        rb.velocity = new Vector3(xvelocity, rb.velocity.y, zvelocity);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "coins")
        {
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().Play();

            //text.SetActive(true);
        }
        
       /* if(collision.gameObject.tag != "coins")
        {
            text.SetActive(false);
        }*/
        
    }

   
    
}
