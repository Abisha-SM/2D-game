using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    
    public int score;
    public Rigidbody2D rb;
    public float flyforce;
    [Header("UI Elements")]
    public GameObject pipemanager;
    public GameObject endscreen;
    public GameObject startscreen;
    public Text scoreText;
   public  GameObject scorescreen;
    public Text Highscore;
    
    //public static event Action OnDeath;



    

    private void Start()
    {
        Time.timeScale = 1f;
        Highscore.text = PlayerPrefs.GetInt("Highscore" ,0).ToString();
        
    }


    void Update()
    {
        if (Input.anyKey)
        {

           
            rb.velocity = new Vector2(0, flyforce);
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                rb.velocity = Vector3.up * flyforce;
            }
        }
    }
    public void Gamestart()
    {
        
        pipemanager.SetActive(true);
        startscreen.SetActive(false);
        rb.gravityScale = 3;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "scorepoint")
        {
            score++;
            scoreText.text = "Score:" + score.ToString() ;
            if (score > PlayerPrefs.GetInt("Highscore", 0))
            {
                PlayerPrefs.SetInt("Highscore", score);
                Highscore.text = score.ToString();
            }
            
            
           
        }
       
        else
        {
            Time.timeScale = 0;
            endscreen.SetActive(true);
            scorescreen.SetActive(true);
            
        }
    }
   


}
