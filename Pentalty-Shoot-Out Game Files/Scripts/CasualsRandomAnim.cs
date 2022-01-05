using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasualsRandomAnim : MonoBehaviour
{
    private Animator anim;

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(3);

            anim.SetInteger("MoveIndex", Random.Range(0, 2));
            anim.SetTrigger("Move");
        }
    }
}