using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuOptions : MonoBehaviour
{
    public AudioSource audioBackground;
    public AudioSource audioClick;
    public AudioSource audioPlay;
    public void Sound()
    {
        audioBackground.Play();
    }
    public void Mute()
    {
        audioBackground.Stop();
    }
    public void Click()
    {
        audioClick.Play();
    }
    public void Play()
    {
        audioPlay.Play();
        StartCoroutine(WaitForAudioToEnd());
    }

    private IEnumerator WaitForAudioToEnd()
    {
        while (audioPlay.isPlaying)
        {
            yield return null; // Wait for the next frame
        }
        SceneManager.LoadSceneAsync(1);
    }

}
