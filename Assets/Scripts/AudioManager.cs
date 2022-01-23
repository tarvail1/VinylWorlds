using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager AudioManagerInstance;
    // Start is called before the first frame update
    void Awake()
    {
        AudioManagerInstance = this;
        
        foreach (Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;

           s.source.volume = s.volume;
           s.source.pitch = s.pitch;

        }
        
        void Start()
        {
            Play("forest");
        }
    }

    // Update is called once per frame
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound:" + name + "not found!");
            return;

        }
        s.source.PlayOneShot(s.clip);
    }

    public void Volume(string name, float vol)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound:" + name + "not found!");
            return;

        }
        s.source.volume = vol;
    }


}

