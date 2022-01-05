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
        if (other.gameObject.tag == "Goal" || other.gameObject.tag == "Out")
        {
            ResetPosition = new Vector3(0.555f, 1.624f, 10.923f);
            transform.position = ResetPosition;
            BallSpeed = GetComponent<Rigidbody>();
            BallSpeed.velocity = Vector3.zero;
            BallSpeed.angularVelocity = Vector3.zero;//ResetVector * Ball_speed;
           
        }
    }
}
