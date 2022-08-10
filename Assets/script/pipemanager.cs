using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemanager : MonoBehaviour
{
    public GameObject pipe;
    public Vector3 pos;
    void Start()
    {
        StartCoroutine(GeneratePipes());
    }

    
    void Update()
    {

    }
    IEnumerator GeneratePipes()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.5f);
            float randy = Random.Range(1.7f, -0.47f);
            pos = new Vector3(0.19f, randy, 0f);
            Instantiate(pipe, pos, Quaternion.identity);
        }

    }
}
