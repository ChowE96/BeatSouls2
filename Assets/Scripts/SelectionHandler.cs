using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionHandler : MonoBehaviour
{

    public Animator props;
    public float transitionTime = 0.75f;
    public GameObject leftArrow;
    public GameObject rightArrow;
    private enum ActState
    {
        Act1,
        Act2,
        Act3,
        Title
    }
    private ActState currState = ActState.Act1;
    private bool switching = false;
    private bool loadLevel = false;
    private Material leftMat;
    private Material rightMat;

    void Start()
    {
         leftMat = leftArrow.GetComponent<Renderer>().material;
         rightMat = rightArrow.GetComponent<Renderer>().material;
         ChangeAlpha(leftMat, 0);
        SoundManager.Instance.playClip(3);
        SoundManager.Instance.songPosition = 0;
    }
    void Update()
    {
        //Switches to either the right or left act
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && !switching)
        {
            bool moveLeft = Input.GetKeyDown(KeyCode.A);
            Debug.Log((moveLeft ? "A" : "D") + " was pressed. Attempting to switch");

            if ((moveLeft && currState == ActState.Act1) || (!moveLeft && currState == ActState.Act3))
            {
                Debug.Log("ERROR: Tried to illegally move " + (moveLeft ? "left" : "right"));
            }
            else
            {
                currState += moveLeft ? -1 : 1;
                Debug.Log("Switching to " + currState);
                switching = true;
                ActTransition(currState);
            }
        }

        //Put props away and load the scene
        if (Input.GetKeyDown(KeyCode.Space) && !loadLevel && !switching)
        {
            loadLevel = true;
            switching = true;
            StartCoroutine(TriggerTrans("Clear"));
        }

        //Go back to title screen
        //WIP
        if (Input.GetKeyDown(KeyCode.Escape) && !loadLevel && !switching)
        {
            loadLevel = true;
            switching = true;
            currState = ActState.Title;
            SoundManager.Instance.stopClip();
            StartCoroutine(TriggerTrans("Clear"));
        }
    }
    
    //Changes between states
    private void ActTransition(ActState currState)
    {
        StartCoroutine(TriggerTrans("Clear"));

        switch(currState)
        {
            case ActState.Act1:
                ChangeAlpha(leftMat, 0);
                StartCoroutine(TriggerTrans("Act1"));
                break;
            case ActState.Act2:
                ChangeAlpha(leftMat, 1);
                ChangeAlpha(rightMat, 1);
                StartCoroutine(TriggerTrans("Act2"));
                break;
            case ActState.Act3:
                ChangeAlpha(rightMat, 0);
                StartCoroutine(TriggerTrans("Act3"));
                break;
            case ActState.Title:
                ChangeAlpha(leftMat, 0);
                ChangeAlpha(rightMat, 0);
                StartCoroutine(TriggerTrans("Title"));
                break;
        }
    }

    //Triggers the animation for transitioning and waits until it is done
    IEnumerator TriggerTrans(string trans)
    {
        props.SetTrigger(trans);
        yield return new WaitForSeconds(transitionTime);
        if (trans != "Clear") switching = false;
        else if (trans == "Clear" && loadLevel)
        {
            switch(currState)
            {
                case ActState.Act1:
                    Debug.Log("Loading Act 1 Scene");
                    SceneManager.LoadScene("Milkman");
                    break;
                case ActState.Act2:
                    Debug.Log("Loading Act 2 Scene");
                    SceneManager.LoadScene("Act2");
                    break;
                case ActState.Act3:
                    Debug.Log("Loading Act 3 Scene");
                    SceneManager.LoadScene("Finale");
                    break;
                case ActState.Title:
                    Debug.Log("Loading title Scene");
                    SceneManager.LoadScene("TitleScreen");
                    break;
            }
        }
    }

    //Makes the arrows disappear
    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat .color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }
}