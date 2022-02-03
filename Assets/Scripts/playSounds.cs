using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSounds : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void playHood()
    {
        Debug.Log("soundPlayed");
        AudioManager.AudioManagerInstance.Play("carHood");
        
    }
}
