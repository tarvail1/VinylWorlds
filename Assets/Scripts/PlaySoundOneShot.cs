using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOneShot : MonoBehaviour
{
    
    private FMOD.Studio.EventInstance sound;

    [SerializeField]public string playEventPath;
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
        sound = FMODUnity.RuntimeManager.CreateInstance(playEventPath);
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject));
        sound.start();
        sound.release();
        //Debug.Log("sound played");
    }

    void PlaySplash()
    {
        sound = FMODUnity.RuntimeManager.CreateInstance("event:/floatingGuySplash");
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject));
        sound.start();
        sound.release();
        //Debug.Log("sound played");
        
    }
    
    
    void PlayBonk()
    {
        sound = FMODUnity.RuntimeManager.CreateInstance("event:/CarBonk");
        sound.setProperty(FMOD.Studio.EVENT_PROPERTY.MAXIMUM_DISTANCE, 10 );
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject));
        sound.start();
        sound.release();
        ;
        
    }
    
    void PlayCarSqueak()
    {
        sound = FMODUnity.RuntimeManager.CreateInstance("event:/CarSqueak");
        sound.setProperty(FMOD.Studio.EVENT_PROPERTY.MAXIMUM_DISTANCE, 10 );
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject));
        sound.start();
        sound.release();
        //Debug.Log("sound played");
        
    }
    
}
