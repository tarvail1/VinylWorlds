using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;

public class playFmod : MonoBehaviour
{
    // Start is called before the first frame update


    private void Start()
    {

    }

    private void DeathSound()
    {

    }

    void playHood()
    {
       FMODUnity.RuntimeManager.PlayOneShot("event:/CarSFX/CarHood",GetComponent<Transform>().position);
    }
}
