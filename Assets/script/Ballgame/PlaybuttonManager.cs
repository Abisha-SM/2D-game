using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaybuttonManager : MonoBehaviour
{
    public Button PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddListener()
    {
        PlayButton.onClick.AddListener(OnSelectPlayButton);
    }
    void OnSelectPlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
