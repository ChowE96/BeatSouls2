using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int currLives = 0;
    public int maxLives = 0; 
    public bool isInvulnerable = false;
    public bool godMode = false;
    public float iFrames = 0.5f;
    
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

    public void LoseLife()
    {
        if (!isInvulnerable && !godMode)
        {
            isInvulnerable = true;
            currLives--;
            StartCoroutine(Invulnerable_Timer());
        }
    }

    IEnumerator Invulnerable_Timer()
    {
        Debug.Log("Player is currently invulnerable");
        yield return new WaitForSeconds(iFrames);
        isInvulnerable = false;
        Debug.Log("Player is no longer invulnerable");
    }
}
