using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMusic : MonoBehaviour
{
    public AudioSource audioSource;

    public void PalyMusic() 
    {
        audioSource.Play();
        DontDestroyOnLoad(audioSource);
    }
}
