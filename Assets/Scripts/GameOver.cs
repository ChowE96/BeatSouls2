using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string LevelName;

    void Start()
    {
        //Reset vars
        SoundManager.Instance.songPosition = 0;
        SoundManager.Instance.songPositionInBeats = 0;
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
