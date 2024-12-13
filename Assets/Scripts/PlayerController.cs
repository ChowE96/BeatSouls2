using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float walkingSpeed;
    public float horizontalMotion, verticalMotion;
    public Animator anim;

    void Start()
    {
        //Set current live to max lives
        GameManager.Instance.currLives = GameManager.Instance.maxLives;
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMotion = Input.GetAxisRaw("Horizontal"); //get horizontal input
        verticalMotion = Input.GetAxisRaw("Vertical"); //get vertical input
        anim.SetBool("IsWalkingUp", false);
        anim.SetBool("IsWalkingDown", false);
        anim.SetBool("IsWalkingRight", false);
        anim.SetBool("IsWalkingLeft", false);
        
        //Walking
        Vector3 totalMovement = new Vector3(walkingSpeed * horizontalMotion * Time.deltaTime, walkingSpeed * verticalMotion * Time.deltaTime, 0); //standard vector motion
        this.transform.position = this.transform.position + totalMovement;

        if (Input.GetAxisRaw("Vertical") > 0) 
        { 
            //Debug.Log("Player is moving up!"); 
            anim.SetBool("IsWalkingUp", true);
            anim.SetBool("IsWalkingDown", false);
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false);
        }
        if (Input.GetAxisRaw("Vertical") < 0) 
        { 
            //Debug.Log("Player is moving down!"); 
            anim.SetBool("IsWalkingDown", true);
            anim.SetBool("IsWalkingUp", false);
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false); 
        }
        if (Input.GetAxisRaw("Horizontal") > 0) 
        { 
            //Debug.Log("Player is moving right!"); 
            anim.SetBool("IsWalkingRight", true);
            anim.SetBool("IsWalkingUp", false);
            anim.SetBool("IsWalkingDown", false);
            anim.SetBool("IsWalkingLeft", false);
        }
        if (Input.GetAxisRaw("Horizontal") < 0) 
        { 
            //Debug.Log("Player is moving left!"); 
            anim.SetBool("IsWalkingLeft", true);
            anim.SetBool("IsWalkingUp", false);
            anim.SetBool("IsWalkingDown", false);
            anim.SetBool("IsWalkingRight", false);
        }

        if (Input.GetKeyDown("g"))
        {
            if (!GameManager.Instance.godMode)
            {
                Debug.Log("Godmode turned on!");
                GameManager.Instance.godMode = true;
            }
            else 
            {
                Debug.Log("Godmode turned off!");
                GameManager.Instance.godMode = false;
            }
        }
    }
}
