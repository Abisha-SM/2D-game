using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : Enemy
{
    public override void FixedUpdate()
    {
        Destroy(gameObject, 2f);
        Debug.Log("Butterfly");
    }
}
