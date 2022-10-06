using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBird : Enemy
    
{
    public override void FixedUpdate()
    {
        Destroy(gameObject, 3f);
        Debug.Log("Bird");
    }

    /*public  override void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }*/
}
