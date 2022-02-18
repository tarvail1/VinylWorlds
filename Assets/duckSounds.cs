using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckSounds : MonoBehaviour
{
    
    private FMOD.Studio.EventInstance sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayDuck()
    {
        sound = FMODUnity.RuntimeManager.CreateInstance("event:/SimoSays");
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject.GetComponentInParent(transform.position)));
        sound.start();
        sound.release();
        Debug.Log("sound played");
    }

}
