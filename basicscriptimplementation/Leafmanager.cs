using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leafmanager : MonoBehaviour
{

    public GameObject leaf;
    public float maxX;
    public float maxZ;
    Rigidbody rb;
    void Start()
    {
        InvokeRepeating("spawnleaf", 0.1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnleaf()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        Vector3 randomspawnpos = new Vector3(randomX, 10f, randomZ);
        Instantiate(leaf, randomspawnpos, Quaternion.identity);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
            GetComponent<Renderer>().material.color = Color.black;
        
    }

}
