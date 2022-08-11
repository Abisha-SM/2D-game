using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadingbar : MonoBehaviour
{
    public Transform loadingbarimage;
    public float TargetAmount = 100.0f;
    public float speed = 30;
    private float currentAmount = 0.0f;
    void Start()
    {
        currentAmount = 0.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentAmount < TargetAmount)
        {
            currentAmount += speed * Time.deltaTime;
            loadingbarimage.GetComponent<Image>().fillAmount = (float)currentAmount / 100.0f;
            
        }
        
        
    }
    
}
