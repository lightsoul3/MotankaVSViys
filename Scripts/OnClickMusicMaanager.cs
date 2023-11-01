using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickMusicMaanager : MonoBehaviour
{
    public GameObject clickSound;
    AudioSource audioSource;

    public void Play() 
    {
        audioSource = clickSound.GetComponent<AudioSource>();
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
    }
}
