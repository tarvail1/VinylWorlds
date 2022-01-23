using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;


public class rotateSun : MonoBehaviour
{
    [SerializeField,Range(0,1)]private float speed = 0.1f;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(speed, speed, 0));
    }
}
