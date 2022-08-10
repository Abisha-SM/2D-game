using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void backgame()
    {
        SceneManager.LoadScene("Front");
    }
}
