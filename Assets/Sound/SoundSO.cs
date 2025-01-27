using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Sound SO", menuName = "Sound/AudioData")]
public class SoundSO : ScriptableObject
{

    [SerializeField]
    AudioData[] audioClips;

    public AudioData[] AudioSource => audioClips;
}

[System.Serializable]
public struct AudioData
{
    public AudioClip audioClip;
    [Range(0f, 1f)] public float privateVolume;
}