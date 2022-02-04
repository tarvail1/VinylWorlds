using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class randomText : MonoBehaviour
{
    private TextMeshPro textField;
    public int nextTextIndex;
    public int currentTextIndex;
    public Rigidbody rb;
    public TextTrigger _textTrigger;
    
    public Dictionary<int, string> SentenceList = new Dictionary<int, string>();
    // Start is called before the first frame update
    void Start()
    {
        _textTrigger = this.GetComponent<TextTrigger>();
        SentenceList.Add(0,"You look so lovely today");
        SentenceList.Add(1,"You are enough");
        SentenceList.Add(2,"The world needs more people like you");
        SentenceList.Add(3,"Hey, is that a new shirt?");
        SentenceList.Add(4,"You can do it, I believe in you!");
        SentenceList.Add(5,"Breathe. Let go of yourself");
        SentenceList.Add(6,"You are a present to the universe");
        SentenceList.Add(7,"Glad to have you here");
        SentenceList.Add(8,"Hope you are well today");
        SentenceList.Add(9,"Take time for yourself");
        SentenceList.Add(10,"I am proud of you");
        SentenceList.Add(11,"When you cant find the sunshine, be the sunshine");
        SentenceList.Add(12,"Don't be afraid to start over");

        currentTextIndex = Random.Range(0, SentenceList.Count);
        textField = GetComponent<TextMeshPro>();
        textField.text = SentenceList[currentTextIndex];
    

    }


void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(textChange(_textTrigger.fadeDuration));
            
        }
    }

IEnumerator textChange(float waitTime)
{
    yield return new WaitForSeconds(waitTime);
    nextTextIndex = Random.Range(0, SentenceList.Count);
    currentTextIndex = nextTextIndex;
    textField.text = SentenceList[currentTextIndex];
    

}

}
