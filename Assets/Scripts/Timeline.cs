using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timeline : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject[] enemies;


    // Start is called before the first frame update
    void Start()
    {
        BeginFight();
    }

    void Update() 
    {
        if (GameManager.Instance.currLives <= 0)
        {
            Debug.Log("Player is dead!");
            SoundManager.Instance.stopClip();
            SceneManager.LoadScene("GameOver");
        }
    }

    void BeginFight()
    {
        SoundManager.Instance.stopClip();
        Debug.Log("Beginning the fight sequence!");
        StartCoroutine(FightCoroutine());
    }

    IEnumerator FightCoroutine()
    {
        //Wait for dialogue then spawn enemies in
        yield return new WaitUntil(() => SoundManager.Instance.songPosition >= 5.1f);

        //Enemies
        Debug.Log("Spawning first wave of enemies!");
        for (int i = 0; i < 7; i++) {
            SpawnDudes(0, 0); //Spawn Cheerio
            yield return new WaitForSeconds(0.3f);
            SpawnDudes(0, 1); //Spawn Cheerio
            yield return new WaitForSeconds(0.3f);
            SpawnDudes(0, 2); //Spawn Cheerio
            yield return new WaitForSeconds(0.3f);
            SpawnDudes(0, 3); //Spawn Cheerio
            yield return new WaitForSeconds(0.3f);
        }

        SpawnDudes(1, 4); //Spawn Pop
        yield return new WaitForSeconds(2f);

        SpawnDudes(3, 0); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(1, 4); //Spawn Pop
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 1); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 2); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        yield return new WaitForSeconds(0.5f);

        SpawnDudes(1, 0); //Spawn Pop
        SpawnDudes(1, 3); //Spawn Pop
        yield return new WaitForSeconds(0.5f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 1); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 2); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);

        SpawnDudes(0, 0); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 1); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 2); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);

        SpawnDudes(0, 0); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 1); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 2); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(0, 3); //Spawn Cheerio

        yield return new WaitUntil(() => SoundManager.Instance.songPosition >= 35.5f);

        SpawnDudes(2, 0); //Spawn Froot
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(2, 1); //Spawn Froot
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(2, 2); //Spawn Froot
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(2, 3); //Spawn Froot
        yield return new WaitForSeconds(1f);

        SpawnDudes(1, 4); //Spawn Pop
        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(0.5f);

        SpawnDudes(1, 4); //Spawn Pop
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        SpawnDudes(0, 0); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        SpawnDudes(0, 0); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 4); //Spawn Lucky
        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 1); //Spawn Lucky
        SpawnDudes(3, 2); //Spawn Lucky
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(3, 0); //Spawn Lucky
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(3, 3); //Spawn Lucky

        yield return new WaitUntil(() => SoundManager.Instance.songPosition >= 59f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 3); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(1, 0); //Spawn Pop
        SpawnDudes(1, 3); //Spawn Pop
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(2, 1); //Spawn Froot
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(2, 2); //Spawn Froot
        yield return new WaitForSeconds(0.2f);

        SpawnDudes(2, 3); //Spawn Froot
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 3); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(0, 4); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(1f);

        SpawnDudes(0, 0); //Spawn Cheerio
        SpawnDudes(0, 1); //Spawn Cheerio
        SpawnDudes(0, 2); //Spawn Cheerio
        SpawnDudes(0, 3); //Spawn Cheerio
        yield return new WaitForSeconds(0.5f);

        SpawnDudes(1, 1); //Spawn Pop
        yield return new WaitForSeconds(0.5f);
        SpawnDudes(1, 2); //Spawn Pop

        yield return new WaitUntil(() => SoundManager.Instance.songPosition >= 79f);

        SpawnDudes(3, 0); //Spawn Lucky
        SpawnDudes(3, 3); //Spawn Lucky

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 3); //Spawn Froot
        SpawnDudes(3, 0); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 3); //Spawn Froot
        SpawnDudes(3, 0); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 3); //Spawn Froot
        SpawnDudes(3, 0); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 2); //Spawn Froot
        SpawnDudes(3, 1); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 1); //Spawn Froot
        SpawnDudes(3, 2); //Spawn Lucky
        yield return new WaitForSeconds(1f);

        SpawnDudes(2, 0); //Spawn Froot
        SpawnDudes(3, 3); //Spawn Lucky
        yield return new WaitForSeconds(1f);
        
        yield return new WaitUntil(() => SoundManager.Instance.songPosition >= 105f);
        SoundManager.Instance.playClip(5);

        yield return new WaitUntil(() => SoundManager.Instance.songPosition >= 111f);
        Debug.Log("End of Song!");
        SceneManager.LoadScene("Finale");


    }

    //Spawn an enemy at a location
    private void SpawnDudes(int enemyType, int location)
    {
        Instantiate(enemies[enemyType], spawnPoints[location].transform.position, Quaternion.identity);
    }

    private void SpawnDudes(int enemyType, int location, float duration)
    {

        Instantiate(enemies[enemyType], spawnPoints[location].transform.position, Quaternion.identity);
    }

    public void SongEvents(int time, int location, int enemyType)
    {

    }


    // Code from Rhythm Doctor
    // float lastbeat; //this is the ‘moving reference point’

    // float bpm = 140;

    // void Start()  {

    //     lastbeat = 0;

    //     crotchet = 60 / bpm;

    // }

    // void Update(){

    //     if (Conductor.songposition > lastbeat + crotchet) {

    //     Flash();

    //     lastbeat += crotchet;

    //     }
    // }
}