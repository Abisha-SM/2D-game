using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Homepage : MonoBehaviour
{
    public Button Newgame;
    public Button Settings;
    public Button Exit;
    // Start is called before the first frame update
    void Start()
    {
        AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnSelectNewgame()
    {
        SceneManager.LoadScene(1);
    }
    void OnSelectSettings()
    {
        SceneManager.LoadScene(4);
    }
    void OnSelectExit()
    {
        SceneManager.LoadScene(6);
    }
    void AddListener()
    {
        Newgame.onClick.AddListener(OnSelectNewgame);
        Settings.onClick.AddListener(OnSelectSettings);
        Exit.onClick.AddListener(OnSelectExit);
    }
}
