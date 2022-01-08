using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTheTarget : MonoBehaviour
{
    public Camera camera;
    public float forceSize; // εγινε public για να μπορει να οριζεται η τιμη μεσα απο το Unity χωρις να χρειαζεται να ανατρεχω στον κωδικα κατα τη διαρκεια της κατασκευης
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition); // ελεγχος για το που βρισκεται ο κερσορας 
                                                                    // μεσω της καμερας οταν κανουμε κλικ και δημιουργιας μιας ακτινας
                                                                    // (ray) απο τη μπαλα (το αντικειμενο που εχει component αυτο το
                                                                    // script) προς τον στοχο

            if (Physics.Raycast(ray, out RaycastHit hitInfo))//χρηση της μεθοδου physics.raycast για να ελεγχξουμε αν διαπερναται
                                                             // καποιο αντικειμενο
            {
                if (hitInfo.collider.gameObject.GetComponent<Target>() != null)// ελεγχος για το αν η μπαλα εχει χτυπησει το αντικειμενο με 
                                                                               // tag Target
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;// υπολογισμος αποστασης του σημειου συγκρουσης με αυτο της αρχικης θεσης της μπαλας
         
                    Vector3 forceDirection = distanceToTarget.normalized;// υπολογισμος της κατευθυνσης που θελουμε η μπαλα να ταξιδεψει. Χωρις το normalized η μπαλα ειτε αποκτουσε
                                                                         // υπερβολικα υψηλη ταχυτητα, ειτε εξαφανιζοταν. Δεν εχω ιδεα γιατι με το να μεατρεπουμε την τιμη σε normalized 
                                                                         //λειτουργει κανονικα, αλλα ηταν ενα απο τα troubleshootings που βρηκα στο διαδικτυο

                    rigidbody.AddForce(forceDirection * forceSize, ForceMode.Impulse);// αναθεση της κατευθυνσης με το επιθυμητο επιπεδο δυναμης που θελουμε να εκτοξευτει η μπαλα
                }
            }
        }
    }
}
