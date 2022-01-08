using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f; // ορισμος μιας float για την τρεχουσα ωρα παιχνιδιου
    float startingTime = 90f; //ορισμος μιας float για την εναρκτηρια ωρα παιχνιδιου
    [SerializeField] Text CountdownText; //Κειμενο που εμφανιζεται στο scoreboard του γηπεδου
    

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime; //μειωση του τρεχοντος χρονου κατα ενα πραγματικο δευτερολεπτο
        CountdownText.text ="Time Left   " + currentTime.ToString("0.0"); //μεταβολη της μεταβλητης τυπου float currentTime σε string για να εμφανιστει στο scoreboard


      
        if(currentTime <=0)
        {
            SceneManager.LoadScene("EndGame"); //με το που γινει το currentTime 0, ληγει το παιχνιδι και μεταφερεται η σκηνη στο τελικο μενου
            currentTime = 0;// τυπικα οριζεται σε 0 για να μην συνεχισει να μετραει αντιστροφα
        }
    }
}
