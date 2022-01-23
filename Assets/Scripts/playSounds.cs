using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       AudioManager.AudioManagerInstance.Play("forest");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
