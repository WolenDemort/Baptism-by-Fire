using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManeger : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private SoundSO audioClips;


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

        int rand = Random.Range(0, audioClips.AudioSource.Length);
        audioSource.clip = audioClips.AudioSource[rand].audioClip;
        audioSource.volume = audioClips.AudioSource[rand].privateVolume;
        audioSource.Play();

    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            isPaused = true;
            audioSource.Pause();
        }
        if (!pauseStatus)
        {
            isPaused = false;
            audioSource.UnPause();
        }
    }
}