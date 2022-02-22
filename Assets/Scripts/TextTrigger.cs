using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class TextTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] public GameObject appearText;
    public TMP_Text m_textComponent;
    private List<Text> textList = new List<Text>();
    public float fadeDuration = 5f;
    
    public Color activeColor;
    public Color inactiveColor;
  



    void Start()
    {
        m_textComponent.color = inactiveColor;
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            //audio.Play();
            StartCoroutine(Fade());
            
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           StartCoroutine(Fadeout());

        }
    }

    private IEnumerator Fade()
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            m_textComponent.color = Color.Lerp(inactiveColor, activeColor, elapsedTime / fadeDuration);
            yield return null;
        }

    }

    private IEnumerator Fadeout()
    {
        Color tempColor;
        
        float elapsedTime = 0;
        
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            m_textComponent.color = Color.Lerp(activeColor, inactiveColor, elapsedTime / fadeDuration);
            yield return null;
        }

    }
}

