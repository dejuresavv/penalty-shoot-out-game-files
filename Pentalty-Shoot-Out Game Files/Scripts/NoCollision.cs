using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollision : MonoBehaviour
{
    Rigidbody m_Rigidbody; // απαιτειται για να ορισουμε την βασικη εντολη για την οποια κατασκευαστηκε αυτο το script
    void Start()
    {
        
        m_Rigidbody = GetComponent<Rigidbody>(); // απαιτειται για να ορισουμε την βασικη εντολη για την οποια κατασκευαστηκε αυτο το script
       
        Physics.IgnoreLayerCollision(9, 10); //  H μπαλα και οι στοχοι στο τερμα διαθετουν απο ενα layer το οποιο εχει αριθμο 9 και 10 αντιστοιχα.
                                             // Οταν αντιληφει το script οτι η μπαλα με τον στοχο εχουν συγκρουστει τοτε αποφασιζει να αγνοησει τη συγκρουση για
                                             // να μπορεσει η μπαλα να καταληξει στα διχτυα. Χωρις αυτο το σκριπτ, οι στοχοι λειτουργουσαν σαν τερμαροφυλακες και απεκρουαν την μπαλα
    }
}
