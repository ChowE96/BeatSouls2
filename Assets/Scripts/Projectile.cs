using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile : MonoBehaviour
{
    private Transform targetTrans;
    private GameObject target;
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        targetTrans = target.transform;   

        // Get the direction to the player
        Vector3 direction = targetTrans.position - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation (z-axis rotation for 2D)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }


    void Update()
    {
        // Move forward
        rb.velocity = transform.right * speed;
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


