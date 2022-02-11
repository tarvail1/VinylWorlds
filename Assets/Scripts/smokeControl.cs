using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;
using UnityEngine.VFX;

public class smokeControl : MonoBehaviour
{
    private VisualEffect smokeEffect;
    
    private float multiplier;
    private Vector3 ForceAmount;
    public FloatVariable multiplierValue;
    public float strenght;

    // Start is called before the first frame update
    void Start()
    {
        smokeEffect = GetComponent<VisualEffect>();
        
    }

    // Update is called once per frame
    void Update()
    {
        multiplier = multiplierValue.GetValue();
        ForceAmount = new Vector3(-multiplier, multiplier,multiplier);
        smokeEffect.SetVector3("Force",ForceAmount);
        smokeEffect.SetVector3("RandomVelocityMax",ForceAmount);
    }
}
