using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject appearText;
    public GameObject[] textObjectList;
    private List<Text> textList = new List<Text>();
    public float fadeSpeed = 0.01f;
    public float timeDisplayed = 10f;
    public Color c;

   


    void Start()
    {
        this.GetComponent<TextMesh>().color = c;


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bang");
        if (other.gameObject.CompareTag("Player"))
        {
            
            StartCoroutine(Fade(fadeSpeed));
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fadeout(fadeSpeed));

        }
    }

    private IEnumerator Fade(float f)
    {
        for (float i = 0; i < 255; i++)
        {
            Debug.Log(c.a);
            c.a += f;
            this.GetComponent<TextMesh>().color = c;
        }
        yield return null;
    }
    
    private IEnumerator Fadeout(float f)
    {
        while (c.a  > 0)
        {
            c.a -= f;
            this.GetComponent<TextMesh>().color = c;
        }
        yield return null;
    }
}

