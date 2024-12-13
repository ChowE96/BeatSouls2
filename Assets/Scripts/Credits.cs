using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 totalMovement = new Vector3(0, speed * Time.deltaTime, 0); //standard vector motion
        this.transform.position = this.transform.position + totalMovement;

        if (SoundManager.Instance.songPosition >= 80)
        {
            SceneManager.LoadScene("ActSelection");
        }
    }
}
