using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrontBack : MonoBehaviour
{
    public Button Backbutton;
   
    void Start()
    {
        AddListener();
    }

   
    void Update()
    {
        
    }
    void OnSelectBackButton()
    {
        SceneManager.LoadScene(0);
    }
    void AddListener()
    {
        Backbutton.onClick.AddListener(OnSelectBackButton);
    }
}
