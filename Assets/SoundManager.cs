using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioSource music;


    public void EnableMusic(bool value){
        music.enabled = value;
    } 
    public void SliderMusic(float value){
        AudioListener.volume = value;
    } 
}
