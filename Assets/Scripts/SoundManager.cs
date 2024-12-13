using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public float songPosition;
    public float songPositionInBeats;
    public float songPercentage;
    public float songMaxPosition = 100;
    

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void playClip(int n)
    {
        audioSource.clip = audioClips[n];
        audioSource.Play();
    }

    public void stopClip()
    {
        audioSource.Stop();
    }
}