using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperDives : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetInteger("DiveIndex", Random.Range(0, 3));
            anim.SetTrigger("Dive");
        }
    }


  
}
