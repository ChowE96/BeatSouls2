using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDiamond : MonoBehaviour
{
    private GameObject target;
    private Transform targetTrans;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        targetTrans = target.transform;   
    }

    // Update is called once per frame
    void Update()
    {
        // Get the direction to the player
        Vector3 direction = targetTrans.position - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Apply the rotation (z-axis rotation for 2D)
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
