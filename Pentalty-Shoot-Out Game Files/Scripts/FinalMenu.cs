using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMenu : MonoBehaviour
{

    //πανομοιοτυπη λογικη με το MainMenu.cs
    public void PlayAgain()//καλειται καθε φορα που πατιεται το κουμπι PLAY AGAIN φορτωνει τη σκηνη του παιχνιδου
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame() // καλειται καθε φορα που πατιεται το κουμπι QUIT και κλεινει τη εφαρμογη.
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
