using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public float speed;
    public float rotationSpeed;
    public Transform playerTransform;


    private void Start(){
        playerTransform = FindObjectOfType<PlayerMovement>().transform;
    }

    private void Update(){
        transform.position += Time.deltaTime * speed * transform.forward;

        Vector3 toRpalyer = playerTransform.position - transform.position;
        Quaternion rotationToPlayer = Quaternion.LookRotation(toRpalyer, Vector3.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotationToPlayer, Time.deltaTime * rotationSpeed);
    }
}
