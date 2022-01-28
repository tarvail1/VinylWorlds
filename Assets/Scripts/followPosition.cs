using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPosition : MonoBehaviour

{

    [SerializeField] Transform targetObj;

    [SerializeField, Range(1, 10)] private float offset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(targetObj.transform.position.x,targetObj.transform.position.y-offset,targetObj.transform.position.z);
    }
}
