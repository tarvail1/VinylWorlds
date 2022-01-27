using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] barrierList;
    private List<Animator> animatorList = new List<Animator>();

    /// [SerializeField] private Animator myAnimationController;


    void Start()
    {
        if (barrierList.Length >= 1) //Make sure list is not empty
        {
            for (int i = 0; i < barrierList.Length; i++)
            {
                animatorList.Add(barrierList[i].GetComponent<Animator>()); //add animators in to the list
                animatorList[i].enabled = false; //turn off each animator in the start
            }
        }
        else
        {
            return; // if list is empty do nothing
        }
    }


    public void FindBarrier(string barrierName)
    {
        if (barrierList.Length >= 1)
        {
            for (int i = 0; i < barrierList.Length; i++)
            {
                animatorList[i].enabled = true;
                animatorList[i].SetBool("isTriggered", true);

            }

        }
     
    }

    public void FindBarrierExit(string barriername)
    {
        for (int i = 0; i < barrierList.Length; i++)
        {
            animatorList[i].SetBool("isTriggered",false);
        }
    }
    

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        string barrierGameObjectName = other.gameObject.name;
        FindBarrier(barrierGameObjectName);

        Debug.Log("bang");
        
    }

    private void OnTriggerExit(Collider other)
    {
        string barrierGameObjectName = other.gameObject.name;
        FindBarrierExit(barrierGameObjectName);
    }
}

