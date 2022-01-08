using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperDives : MonoBehaviour
//Συνεργαζεται με το GKAnimController.controller
{
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))//καθε φορα που πατιεται αριστερο κλικ για να σουταρουμε την μπαλα σε ενα στοχο, ταυτοχρονα εκτελειται και
                                        // μια απο τις 3 διαφορετικες κινησεις του τερματοφυλακα. Αρχικα ειναι σε idle μορφη και εχει 3 επιλογες κινησης
                                        // οι οποιες βασιζονται σε τυχαιοτητα με την εντολη 1. 
        {
            anim.SetInteger("DiveIndex", Random.Range(0, 3));// ΕΝΤΟΛΗ 1
            anim.SetTrigger("Dive"); // παιρνει τον τυχαιο δεικτη που διαλεξε απο την εντολη 1 και εκτελει το animation που του αντιστοιχει.
        }
    }


  
}
