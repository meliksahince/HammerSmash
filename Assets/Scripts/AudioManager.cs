﻿using UnityEngine.Audio;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake (){
        foreach(Sound s in sounds){
            
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch  = s.pitch;
        }
    }

    public void Play (string name){
        Sound s = System.Array.Find(sounds, sounds => sounds.name == name);
        s.source.Play();
    }
}
