using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class rainbowTrigger : MonoBehaviour
{
    public float fadeDuration;
    public Material mat;
    private bool enableFade;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Random.Range(0, 100) < 25 )
        {
            enableFade = true;
        }
        if (other.gameObject.CompareTag("Player") && enableFade)
        {
            StartCoroutine(RainbowFade());

        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && enableFade)
        {
            StartCoroutine(RainbowFadeOut());

        }
    }

    private IEnumerator RainbowFade()
    {
        float elapsedTime = 0;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            mat.SetFloat("_rainbowLerp", Mathf.Lerp(0,1,elapsedTime/fadeDuration));
            yield return null;
        }

        
    }
    
    private IEnumerator RainbowFadeOut()
    {
        float elapsedTime = 0;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            mat.SetFloat("_rainbowLerp", Mathf.Lerp(1,0,elapsedTime/fadeDuration));
            yield return null;
        }
        enableFade = false;
    }
}
