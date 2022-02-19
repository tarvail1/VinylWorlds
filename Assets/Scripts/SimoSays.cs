using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class SimoSays : MonoBehaviour
{
    private FMOD.Studio.EventInstance Simolines;
    private FMOD.Studio.EventDescription SimoDescription;
    private FMOD.Studio.PARAMETER_DESCRIPTION pd;
    private FMOD.Studio.PARAMETER_ID pID;
    private int outIndex;
    private FMOD.Studio.EventInstance sound;
    
    [SerializeField] public IntVariable simoIndex;
    int simoInd;
    private StudioParameterTrigger paramTrig;
    [SerializeField]public string playEventPath;
    
    
    
    void Start()
    {
        // simoInd = simoIndex.GetValue();
        // Simolines = FMODUnity.RuntimeManager.CreateInstance("event:/SimoSays");
        //
        // SimoDescription = FMODUnity.RuntimeManager.GetEventDescription("event:/SimoSays");
        // SimoDescription.getParameterDescriptionByIndex(simoInd, out pd);
        // playSimo = pd.GetHashCode();
        // Debug.Log("Simo says" + playSimo);
        //
        // simoInd = simoIndex.GetValue();
    }

    // Update is called once per frame
 
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            StartCoroutine(playSimo(2f));
            
        }
    }
    
    
    
    IEnumerator playSimo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        sound = FMODUnity.RuntimeManager.CreateInstance(playEventPath);
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject));
        sound.setParameterByName("SimoIndex", simoIndex.GetValue());
        sound.start();
        sound.release();
        Debug.Log("sound played");
    }

    
    
}
