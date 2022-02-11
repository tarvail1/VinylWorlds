using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColor : MonoBehaviour
{
    // Start is called before the first frame update
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.SetFloat("_BaseColorHue", Random.Range(0, 360));
    }

}