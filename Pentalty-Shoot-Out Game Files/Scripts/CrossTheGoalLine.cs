using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTheGoalLine : MonoBehaviour
{
    Vector3 ResetVector; //δεν χρησιμοποιηθηκε σε αυτο το σκριπτ, αλλα στο ResetTheBall.cs
    Rigidbody BallSpeed; //δεν χρησιμοποιηθηκε σε αυτο το σκριπτ, αλλα στο ResetTheBall.cs
    float Ball_speed = 0.0f; //δεν χρησιμοποιηθηκε σε αυτο το σκριπτ, αλλα στο ResetTheBall.cs
    AudioSource goal; //ηχητικο εφε οταν μπαινει γκολ
    public GameController Controller; //δημιουργια μεταβλητης τυπου GameController που χρησιμοποιειται για να να αυξησει το σκορ οποτε μπαινει γκολ


    private void OnTriggerEnter(Collider other) //καθε φορα που η μπαλα (GameOBject του τρεχοντος Scirpt) συγκρουεται με τον αορατο τοιχο πισω απο τη γραμμη του τερματος για να μετρησει γκολ
    {
        if(other.gameObject.tag == "Goal") //ο αορατος τοιχος πισω απο το τερμα εχει tag "Goal"
        {                                   // Εαν η μπαλα δηλαδη χτυπησει το αντικειμενο που εχει tag "Goal"

            goal = GetComponent<AudioSource>();//φορτωνεται το ηχητικο εφε goal
            goal.Play();//παιζει το ηχητικο εφε γκολ
            Controller.IncrementScore();//καλει το game controller και την συναρτηση IncrementScore
            
        }
    }
    


}
