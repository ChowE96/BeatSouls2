using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveProjectile : MonoBehaviour
{
    private Transform targetPos;
    private GameObject target;
    private Vector2 currTargetPos;
    private Vector2 currPos;
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool lightFuse;
    public float fuseDelay = 2f;
    private bool playerInside = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        targetPos = target.transform;
        currTargetPos = targetPos.position;
        currPos = new Vector2(0.0f, 0.0f);
        lightFuse = false;
        StartFuse();
    }


    void Update()
    {
        // Move forward
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, currTargetPos, step);

        // if the bomb's fuse is lit explode
        if (lightFuse)
        {
            lightFuse = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bomb detected a player!");
            playerInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bomb no longer detects a player!");
            playerInside = false;
        }
    }

    private void Explode()
    {
        print("The bomb's exploding!");
        if (playerInside)
        {
            GameManager.Instance.LoseLife();
        }
        else print("No player inside area!");
    }

    private void StartFuse()
    {
        StartCoroutine(WaitTimer(fuseDelay));
    }

    IEnumerator WaitTimer(float fuseDelay)
    {
        yield return new WaitForSeconds(fuseDelay);

        lightFuse = true;
    }

    private void Explosion()
    {
        Destroy(gameObject);
    }
}