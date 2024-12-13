using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile_Line : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.rotation = Quaternion.Euler(0, 0, 180);
    }


    void Update()
    {
        // Move forward
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Projectile has hit a player!");
            GameManager.Instance.LoseLife();
            Destroy(gameObject);
        }

        if (other.CompareTag("Projectile_Wall"))
        {
            Debug.Log("Projectile has hit a wall!");
            Destroy(gameObject);
        }
    }
}


