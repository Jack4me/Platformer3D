using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour {
    public Rigidbody rb;
    public float speedCarrot = 10;
    private void Start(){
        Vector3 playerPos = FindObjectOfType<PlayerMovement>().transform.position;
        Vector3 positionToPlayer = (playerPos - transform.position).normalized;
        rb.velocity = positionToPlayer * speedCarrot;

    }
}
