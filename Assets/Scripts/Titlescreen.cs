using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlescreen : MonoBehaviour
{
    public string LevelName;
    public Animator logo;
    public Animator leftCurtain;
    public Animator rightCurtain;
    public Animator buttons;
    public float transitionTime = 1f;

    public void StartTransition()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        logo.SetTrigger("Start");
        leftCurtain.SetTrigger("Start");
        rightCurtain.SetTrigger("Start");
        buttons.SetTrigger("Start");
        SoundManager.Instance.playClip(2);
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(LevelName);
    }
}
