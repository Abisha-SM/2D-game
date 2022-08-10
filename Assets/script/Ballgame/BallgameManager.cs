using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallgameManager : MonoBehaviour
{
    public GameObject Ballprefab;
    public Vector3 pos;
    public Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateBalls());
        
    }


    void Update()
    {

    }
    IEnumerator GenerateBalls()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            float randy = Random.Range(1.7f, 20);
            pos = new Vector3(0.19f, randy, 0f);
            Instantiate(Ballprefab, pos, Quaternion.identity);
        }

    }
    private void OnMouseDown()
    {
        Destroy(Ballprefab);
        

    }

}
