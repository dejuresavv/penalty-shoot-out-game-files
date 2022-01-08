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

    public void IncrementScore() //καλειται απο το script CrossTheGoalLine.cs καθε φορα που γινεται συγκρουση μεταξυ της μπαλας και του αορατου τοιχου πισω απο το τερμα
    {
        Score++; //αυξηση της int score κατα 1
        Debug.Log("goal");//ενα απλο debug μηνυμα
        Debug.Log("Score is: " + Score); //για επιβεβαιωση λειτουργιας
        ScoreText.text = "GOALS       " + Score.ToString();//ετσι εμφανιζεται στο scoreboard του γηπεδου
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
