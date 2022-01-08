using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
//Το συγκεκριμενο σκριπτ τοποθετειται σε ενα GamePbject το οποιο περιεχει το κουμπι PLAY και το κουμπι QUIT του αρχικου μενου
                            
{
    public void PlayGame() //Η PlayGame() καλειται καθε φορα που πατιεται το κουμπι PLAY του αρχικου μενου.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); /* //ενας διαφορετικος τροπος απο το να εκτελεστει "SceneManager.LoadScene("Game");"
                                                                              η συγκεκριμενη εντολη δουλευει αναλογα με το τι δεικτη εχουμε ορισει στο build settings
                                                                               του unity, για καθε σκηνη. Η πρωτη σκηνη ειναι το κεντρικο μενου με δεικτη 0, η δευτερη
                                                                               ειναι το παιχνιδι με δεικτη 1 και το τελικο μενου με δεικτη 2. Η συγκεκριμενη εντολη
                                                                                παντα προσθετει +1 στο 0, οποτε παντα μεταφερεται στη σκηνη του παιχνιδιου.*/
    }

    public void QuitGame ()//καλειται καθε φορα που πατιεται το κουμπι quit
    {
        Debug.Log("i did quit!");//ενα απλο μηνυμα debug για να επιβεβαιωθει η λειτουργια του κουμπιου καθως φτιαχνοτανε
        Application.Quit();//κλεινει την εφαρμογη.
    }
}
