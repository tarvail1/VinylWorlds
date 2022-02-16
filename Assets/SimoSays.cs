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
    
    [SerializeField] public IntVariable simoIndex;
    int simoInd;
    private StudioParameterTrigger paramTrig;
    private int playSimo;
    
    
    void Start()
    {
        simoInd = simoIndex.GetValue();
        Simolines = FMODUnity.RuntimeManager.CreateInstance("event:/SimoSays");
        
        SimoDescription = FMODUnity.RuntimeManager.GetEventDescription("event:/SimoSays");
        SimoDescription.getParameterDescriptionByIndex(simoInd, out pd);
        playSimo = pd.GetHashCode();
        Debug.Log("Simo says" + playSimo);
       
        simoInd = simoIndex.GetValue();
    }

    // Update is called once per frame
    void Update()
    {
        simoInd = simoIndex.GetValue();
        
        
    }
}
