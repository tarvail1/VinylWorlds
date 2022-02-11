using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class bubbleControl : MonoBehaviour
{
    private VisualEffect bubbleEffect;
    private float multiplier;
    public FloatVariable multiplierValue;
    // Start is called before the first frame update
    void Start()
    {
        
        bubbleEffect = GetComponent<VisualEffect>();
      
    }

    // Update is called once per frame
    void Update()
    {
        multiplier = multiplierValue.GetValue();  
        bubbleEffect.SetFloat("TurbulenceIntensity", multiplier*5);
    }
}
