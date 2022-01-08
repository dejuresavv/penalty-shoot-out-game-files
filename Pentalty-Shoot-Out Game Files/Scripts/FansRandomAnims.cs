using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FansRandomAnims : MonoBehaviour
{

    // Ομοια λογικη με το Script CasualsRandomAnim.cs, αλλα το τρεχον script τρεχει για τους οπαδους πισω απο το τερμα
    private Animator anim;

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

         while(true)
         {
             yield return new WaitForSeconds(3);

             anim.SetInteger("CheerIndex", Random.Range(0, 3));
             anim.SetTrigger("Cheer");
         }
    }
}
