using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;
using UnityEngine.VFX;

public class smokeControl : MonoBehaviour
{
    private VisualEffect smokeEffect;
    public PathFollower pathFollower;
    public GameObject Camera;
    private float multiplier;
    private Vector3 ForceAmount;
    public FloatVariable multiplierValue;

    // Start is called before the first frame update
    void Start()
    {
        smokeEffect = GetComponent<VisualEffect>();
        Camera = GameObject.FindWithTag("MainCameraControl");
        
        ForceAmount = new Vector3(-multiplier*4, multiplier*10, 0);
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
