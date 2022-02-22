
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using FMODUnity;
using Unity.VisualScripting;

public class randomText : MonoBehaviour
{
    private TextMeshPro textField;
    private int nextTextIndex;
    private int currentTextIndex;
    private Rigidbody rb;
    private TextTrigger _textTrigger;
    [SerializeField] public IntVariable Simoindex;
    private FMOD.Studio.EventInstance sound;

    
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
        SentenceList.Add(13,"You are beautiful");
        SentenceList.Add(14,"Nothing is impossible");
        SentenceList.Add(15,"Be courageous");
        SentenceList.Add(16,"You can be whatever you want");
        SentenceList.Add(17,"You look lovely today");
        SentenceList.Add(18,"It's never too late to set a new dream");
        SentenceList.Add(19,"Embrace the good in you");
        SentenceList.Add(20,"Believe you can and you’re halfway there");
        SentenceList.Add(21,"You can shake the world");
        SentenceList.Add(22,"You are a rainbow in someone's cloud");
        SentenceList.Add(23,"Life is like a open highway");
        SentenceList.Add(24,"It's ok to have bad days too");
        SentenceList.Add(25,"Impossible is only an opinion");
        SentenceList.Add(26,"You shine like a diamond");
        SentenceList.Add(27,"You are a series of small nice things brought together");
        SentenceList.Add(28,"Hey you, just you");
        SentenceList.Add(29,"Don't worry about the small things");
        SentenceList.Add(30,"Focus on the positive");
        SentenceList.Add(31,"Hold on, you can do it");
        SentenceList.Add(32,"Wherever you go, go with all your heart");
        SentenceList.Add(33,"Begin anywhere");
        SentenceList.Add(34,"You're worth it");
        SentenceList.Add(35,"Sunshine all the time makes a desert");
        SentenceList.Add(36,"You’re so much stronger than you think");
        SentenceList.Add(37,"Welcome yourself into you");
        SentenceList.Add(38,"There is a universe in all of us");
        SentenceList.Add(39,"You are pure and loved");
        SentenceList.Add(40,"Everything is in your reach");
        SentenceList.Add(41,"Find the hidden truth within");
        SentenceList.Add(42,"You are safe");
        SentenceList.Add(43,"Your life is a gift");
        SentenceList.Add(44,"The essence of life waits for you");
        SentenceList.Add(45,"See all that you can become");
        SentenceList.Add(46,"Your soul is beautiful");
        SentenceList.Add(47,"Protect your heart");
        SentenceList.Add(48,"You are important");
        SentenceList.Add(49,"Eternity is a state of mind");
        SentenceList.Add(50,"Let happiness inside you");
        SentenceList.Add(51,"Imagine your own melody");
        SentenceList.Add(52,"Shooting stars sing your name");
        SentenceList.Add(53,"The prison of fear will not hold you");
        SentenceList.Add(54,"Love always finds you");
        SentenceList.Add(55,"Your heart is powerful");
        SentenceList.Add(56,"The universe will reveal your story");
        SentenceList.Add(57,"Life is your journey");
        SentenceList.Add(58,"You are a beautiful secret");
        SentenceList.Add(59,"Anything you want will be true");
        SentenceList.Add(60,"You are a beautiful painting come to life");
        SentenceList.Add(61,"You have all the colors within you");
        SentenceList.Add(62,"You are worth more than all the gold in the world");
        SentenceList.Add(63,"Your essence shines light upon everything");
        SentenceList.Add(64,"Let go of all fear");
        
        
        
        currentTextIndex = Random.Range(0, SentenceList.Count);
        Simoindex.SetValue(currentTextIndex);
        //Debug.Log(currentTextIndex);
        textField = GetComponent<TextMeshPro>();
        textField.text = SentenceList[currentTextIndex];
    

    }


    // private void OnTriggerEnter(Collider other)
    // {
    //
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //
    //         StartCoroutine(playSimo(2f));
    //         
    //     }
    // }


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
        Simoindex.SetValue(nextTextIndex);
        textField.text = SentenceList[currentTextIndex];
    

    }

    IEnumerator playSimo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        sound = FMODUnity.RuntimeManager.CreateInstance("event:/SimoSays");
        sound.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(this.gameObject));
        sound.setParameterByName("SimoIndex", Simoindex.GetValue());
        sound.start();
        sound.release();
        Debug.Log("sound played");
    }
    
}