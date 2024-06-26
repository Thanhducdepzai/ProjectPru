using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public void Sound()
    {
        audioSource.Play();
    }
    public void Mute()
    {
        audioSource.Stop(); 
    }
}
