using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;


public class rotateObject : MonoBehaviour
{
    [SerializeField, Range(0, 4)] private float speed = 0.1f;
    private GameObject citybase;
    public bool x = false;
    public bool y = false;
    public bool z = false;
    private float xSpeed = 0;
    private float ySpeed = 0;
    private float zSpeed = 0;
    public float  scratchMultiplier;
    

    void Start()
    {
        //assign the object to the one with disc rotate script
        citybase = GameObject.FindWithTag("base");
    }

    // Update is called once per frame
    void Update()
    {
        //Get the value for the multiplier
        scratchMultiplier = citybase.GetComponent<rotateWorld>().multiplier;

        if (x)
        {
            xSpeed = speed* scratchMultiplier;
        }

        if (y)
        {
            ySpeed = speed* scratchMultiplier;

        }

        if (z)
        {
            zSpeed = speed* scratchMultiplier;
        }



        this.transform.Rotate(new Vector3(xSpeed, ySpeed, zSpeed));
       
    }
}

