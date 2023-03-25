using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody playerRB;
    public float moveSpeed;
    public float friction;
    public float jumpSpeed;
    public float maxSpeed;
    public bool isGround;
    public Transform colliderPlayer;
    
    

    private void Update(){
         
        
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S) || isGround == false){
            colliderPlayer.transform.localScale = Vector3.Lerp(colliderPlayer.transform.localScale,
                new Vector3(1, 0.5f, 1), Time.deltaTime * 15);
        }
        else{
            colliderPlayer.transform.localScale = new Vector3(1, 1, 1);
            
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            if (isGround){
                Jump();
            }
        }
    }

    public void Jump(){
        playerRB.AddForce(0, jumpSpeed, 0, ForceMode.VelocityChange);
    }

    private void FixedUpdate(){
        float speedMultilpaer = 1;

        if (isGround == false){
            speedMultilpaer = 0.8f;
        }

        if (playerRB.velocity.x > maxSpeed && Input.GetAxis("Horizontal") > 0){
            speedMultilpaer = 0.1f;
        }

        if (playerRB.velocity.x < -maxSpeed && Input.GetAxis("Horizontal") < 0){
            speedMultilpaer = 0.1f;
        }

        playerRB.AddForce(Input.GetAxis("Horizontal") * moveSpeed * speedMultilpaer, 0, 0, ForceMode.VelocityChange);
        playerRB.AddForce(-playerRB.velocity.x * friction, 0, 0, ForceMode.VelocityChange);
    }

    private void OnCollisionStay(Collision collisionInfo){
        float angle = Vector3.Angle(collisionInfo.contacts[0].normal, Vector3.up);
        if (angle < 60){
            isGround = true;
        }
    }

    private void OnCollisionExit(Collision other){
        isGround = false;
    }
}