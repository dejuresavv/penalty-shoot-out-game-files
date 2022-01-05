using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 90f;
    [SerializeField] Text CountdownText;
    

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text ="Time Left   " + currentTime.ToString("0.0");


      
        if(currentTime <=0)
        {
            SceneManager.LoadScene("EndGame");
            currentTime = 0;
        }
    }
}
