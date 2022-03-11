using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Object = System.Object;

public class LevelManager : MonoBehaviour
{
    private List<string> Levels = new List<string>()
    {
        "ForestScene",
        "Underwater",
        "CityScene 1"
    };
    public Color inactiveColor;
    public Color activeColor;

    private float currentTime;
    private float sceneDuration = 240;
    private float fadeDuration = 5;
    [SerializeField] public RawImage canvas;
    public int currentLevel = 0;



    // Start is called before the first frame update
    void Start()
    {
        canvas = this.gameObject.GetComponent<RawImage>();
        currentTime = 0;
        StartCoroutine(FadeIn());
        

    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= sceneDuration)
        {
            StartCoroutine(FadeOut());
        }

    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvas.color = Color.Lerp(activeColor, inactiveColor, t: elapsedTime/fadeDuration);
            yield return null;
        }

        
    }
    
    private IEnumerator FadeOut()
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvas.color = Color.Lerp(inactiveColor, activeColor, elapsedTime/fadeDuration);
            yield return null;
        }

        if (currentLevel <= 2)
        {
            currentLevel += 1;
        }
        else
        {
            currentLevel = 0;
        }

        

        SceneManager.LoadScene(Levels[currentLevel]) ;
        Debug.Log(currentLevel);
    }
}   
