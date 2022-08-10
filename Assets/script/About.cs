using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class About : MonoBehaviour
{
    public Button Back;
    // Start is called before the first frame update
    void Start()
    {
        AddListeners();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnSelectBack()
    {
        SceneManager.LoadScene(0);
    }
    void AddListeners()
    {

        Back.onClick.AddListener(OnSelectBack);
    }
}
