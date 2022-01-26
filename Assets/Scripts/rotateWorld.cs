using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class rotateWorld : MonoBehaviour
{
    public float speed;
    public float multiplier;
    public static rotateWorld rotateWorldInstance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0,0,speed+ multiplier));

        if (Input.GetMouseButton(0))
        {
            float Yaxis = Input.GetAxis("Mouse Y");
            Yaxis = Yaxis * -1; 
            multiplier = (float)Yaxis;
            
            Debug.Log(multiplier);
        }
    }
}
