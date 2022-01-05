using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Renderer renderer;
        
    
    void Start()
    {
        renderer = GetComponent<Renderer>(); 
    }

    void Update()
    { 
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.blue;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.red;
    }

}
