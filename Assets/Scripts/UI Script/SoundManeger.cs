using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManeger : MonoBehaviour
{
    [SerializeField]
   private AudioSource audioSource;
    [SerializeField]
    private AudioClip[] audioClips;
    [SerializeField]
    private float totalVolume;
    [SerializeField]
    private float privateVolume;

    private bool isPaused = false;
    

    void Start()
    {      
        PlayBackgroundSound();        
    }
  

    void FixedUpdate()
    {
        if (!audioSource.isPlaying && !isPaused) 
        {
            PlayBackgroundSound();
        }
    }
    void PlayBackgroundSound()
    {
        audioSource.clip = audioClips[ Random.Range(0, audioClips.Length)];

        if (audioSource.clip.name == "SoundText1" || audioSource.clip.name == "SoundText2")
             audioSource.volume = privateVolume;       
        else audioSource.volume = totalVolume;

           audioSource.Play();

    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {            
            isPaused = true;
            audioSource.Pause();
        }
       if(!pauseStatus)
        {           
            isPaused = false;
            audioSource.UnPause();
        }
    }
}
