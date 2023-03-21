using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour {
    public Vector3 eulerLeft;
    public Vector3 eulerRight;
    public Transform playerTransform;
    public Vector3 direction;
    public float smoothRate = 5;
    private void Update(){
        if (transform.position.x < playerTransform.transform.position.x){
            direction = eulerLeft;
        }
        else{
            direction = eulerRight;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(direction), Time.deltaTime * smoothRate);
    }
}