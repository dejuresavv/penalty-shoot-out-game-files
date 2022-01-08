using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
//Το συγκεκριμενο σκριπτ τοποθετειται σε ενα GamePbject το οποιο περιεχει το κουμπι PLAY και το κουμπι QUIT του αρχικου μενου
                            
{
    public void PlayGame() //Η PlayGame() καλειται καθε φορα που πατιεται το κουμπι PLAY του αρχικου μενου.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Debug.Log("i did quit!");
        Application.Quit();
    }
}
