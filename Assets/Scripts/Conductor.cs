using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    //Song beats per minute
    //This is determined by the song you're trying to sync up to
    public float songBpm;

    //The number of seconds for each song beat
    public float secPerBeat;

    //Current song position, in seconds
    public float songPosition;

    //Current song position, in beats
    public float songPositionInBeats;

    //How many seconds have passed since the song started
    public float dspSongTime;

    //an AudioSource attached to this GameObject that will play the music.
    public AudioSource musicSource;

    void Start()
    {
        //Load the AudioSource attached to the Conductor GameObject
        //musicSource = GetComponent<AudioSource>();

        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;

        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;

        //Start the music
        musicSource.Play();
    }

    void Update()
    {
        //determine how many seconds since the song started and update in SoundManager
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);
        SoundManager.Instance.songPosition = songPosition;

        //determine how many beats since the song started and update in SoundManager
        songPositionInBeats = songPosition / secPerBeat;
        SoundManager.Instance.songPositionInBeats = songPositionInBeats;

        SoundManager.Instance.songPercentage = SoundManager.Instance.songMaxPosition - songPosition;

    }
}