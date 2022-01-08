using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTheGoalLine : MonoBehaviour
{
    Vector3 ResetVector; //δεν χρησιμοποιηθηκε σε αυτο το σκριπτ
    Rigidbody BallSpeed;
    float Ball_speed = 0.0f;
    AudioSource goal;
    public GameController Controller; 


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal")
        {

            goal = GetComponent<AudioSource>();
            goal.Play();
            Controller.IncrementScore();
            
        }
    }
    


}
