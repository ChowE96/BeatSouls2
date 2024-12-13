using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float cameraSpeed;
    private float horizontalMotion;
    void Update()
    {
        horizontalMotion = Input.GetAxisRaw("Horizontal"); //get horizontal input
        Vector3 totalMovement = new Vector3(cameraSpeed * horizontalMotion * Time.deltaTime, 0, 0); //standard vector motion
        this.transform.position = this.transform.position + totalMovement;
    }

}
