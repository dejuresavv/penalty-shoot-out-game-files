using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text ScoreText;
    private int Score = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IncrementScore()
    {
        Score++;
        Debug.Log("goal");
        Debug.Log("Score is: " + Score);
        ScoreText.text = "GOALS       " + Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
