using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControlRandom : MonoBehaviour
{

    private Animator anim;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animator>();

        while (true)
        {
            yield return new WaitForSeconds(3);
            
            anim.SetInteger("animIndex",Random.Range(0,3));
            anim.SetTrigger("trigger");
        }
    }


}
