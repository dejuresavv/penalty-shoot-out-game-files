using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualsRandomAnim : MonoBehaviour
{
    private Animator anim; //Δημιουργια μεταβλητης τυπου Animator της Unity

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(3); //Σταματει το σκριπτ για 3 δευτερολεπτα μεχρι να παιξει το επομενο Animation
                                                

            anim.SetInteger("MoveIndex", Random.Range(0, 2)); // εχουν οριστει 3 animations με εναν δεικτη η καθεμια. Η συγκεκριμενη εντολη επιλεγει τυχαια εναν δεικτη
            anim.SetTrigger("Move"); // ενεργοποιει το animation με ονομα Move
        }
    }
}
