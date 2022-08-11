using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitscreenManager : MonoBehaviour
{
    public Button yesbutton;
    public Button nobutton;
    // Start is called before the first frame update
    void Start()
    {
        AddListeners();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnSelectno()
    {
        SceneManager.LoadScene(0);
    }
    /*void OnSelectyes()
    {
        SceneManager.LoadScene();
    }*/
    void AddListeners()
    {

         //yesbutton.onClick.AddListener(OnSelectyes);
        nobutton.onClick.AddListener(OnSelectno);
    }
}
