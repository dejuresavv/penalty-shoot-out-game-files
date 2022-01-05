using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollision : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    void Start()
    {
        
        m_Rigidbody = GetComponent<Rigidbody>();
       
        Physics.IgnoreLayerCollision(9, 10);
    }
}
