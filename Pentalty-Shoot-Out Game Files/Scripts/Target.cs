using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // ενα script περισσοτερο αισθητικης βελτιωσης UI του παιχνιδιου. Καθε φορα που ο κερσορας περναει πανω απο ενα στοχο, αλλαζει χρωμα για να υποδειξει το γεγονος
    // οτι ειναι ετοιμος για να δεχτει τη μπαλα.
    private Renderer renderer;
        
    
    void Start()
    {
        renderer = GetComponent<Renderer>(); //μεσω της renderer ειναι εφικτο να αλλαζουμε χρωματα κατα τη διαρκεια του παιχνιδιου
    }

    void Update()
    { 
    }

    private void OnMouseEnter()
    {
    // γινεται μπλε οταν ο κερσορας ειναι πανω στον στοχο
        renderer.material.color = Color.blue;
    }

    private void OnMouseExit()
    {
    // επιστρεφει στο κοκκινο χρωμα οταν ο κερσορας απομακρυνεται
        renderer.material.color = Color.red;
    }

}
