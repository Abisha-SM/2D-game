using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basic : MonoBehaviour
{
    public GameObject cube;
    Rigidbody rb;
    public GameObject wintext;
    //float XInput;
    //float ZInput;
    //public float speed;
    void Start()
    {
        // Destroy(cube,3f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destroy(cube);
            rb.AddForce(Vector3.up * 500);
        }*/

       // XInput = Input.GetAxis("Horizontal");
        //XInput = Input.GetAxis("vertical");
        //rb.AddForce(XInput * speed, 0, ZInput * speed);
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            //Destroy(gameObject);
            wintext.SetActive(true);
        }
    }*/
    /*private void OnMouseDown()
    {
        Destroy(cube);
    }*/

}
