using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour {
    public Rigidbody rbHen;
    public Transform transformPlayer;
    public float time;
    public float speed;
    private void Start(){
        transformPlayer = FindObjectOfType<PlayerHealth>().transform;
    }

    private void FixedUpdate(){
        Vector3 normalize = (transformPlayer.position - rbHen.transform.position).normalized;
        Vector3 force = rbHen.mass * (normalize * speed - rbHen.velocity) / time;
        Debug.Log(force);
        rbHen.AddForce(force);
    }
}
