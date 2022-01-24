using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;


public class rotateObject : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float speed = 0.1f;
    public bool x = false;
    public bool y = false;
    public bool z = false;
    private float xSpeed = 0;
    private float ySpeed = 0;
    private float zSpeed = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (x)
        {
            xSpeed = speed;
        }

        if (y)
        {
            ySpeed = speed;

        }

        if (z)
        {
            zSpeed = speed;
        }



        this.transform.Rotate(new Vector3(xSpeed, ySpeed, zSpeed));
    }
}

