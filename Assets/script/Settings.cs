using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    
    public Button Exit;
    public Button About;
    public AudioSource audiosource;
    private float musicvolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audiosource.Play();
        AddListeners();
        
    }

    // Update is called once per frame
    void Update()
    {
        audiosource.volume = musicvolume;
    }
    void OnSelectExit()
    {
        SceneManager.LoadScene(0);
    }
    void OnSelectAbout()
    {
        SceneManager.LoadScene(5);
    }
    void AddListeners()
    {
        Exit.onClick.AddListener(OnSelectExit);
        About.onClick.AddListener(OnSelectAbout);
    }
    public void updatevolume(float volume)
    {
        musicvolume = volume;
       
    }
   
    
}
