using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHandler : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BallReceiver")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
        
    }
    
}
