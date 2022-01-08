using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTheBall : MonoBehaviour
{
    Vector3 ResetPosition;
    Rigidbody BallSpeed;
    float Ball_speed = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal" || other.gameObject.tag == "Out") // αν η μπαλα ερθει σε συγκρουση με το αορατο αντικειμενο πισω σπο το τερμα που μετραει \
                                                                             // γκολ ή με τα αορατα αντικειμενα γυρω απο το γηπεδο.
        {
            ResetPosition = new Vector3(0.555f, 1.624f, 10.923f); //αναθεση στην μεταβλητη ResetPosition τυπου Vector3, τις συντεταγμενες της αρχικης θεσης της μπαλας
            transform.position = ResetPosition; //μεταφορα της μπαλας στις αρχικες συντεταγμενες (καθως εχει μετακινηθει)
            BallSpeed = GetComponent<Rigidbody>();
            BallSpeed.velocity = Vector3.zero; //μηδενισμος της ταχητυτας κινησης μεταφορας
            BallSpeed.angularVelocity = Vector3.zero; // μηδενισμος της ταχυτητας περιστροφης (ειναι αναγκαια καθως χωρις αυτη οταν επαναφερεται η μπαλα, συγκρατει ταχυτητα περιστροφης
                                                      // και μετακινειται
           
        }
    }
}
