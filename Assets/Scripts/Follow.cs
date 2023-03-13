using System;
using UnityEngine;

public class Follow : MonoBehaviour {
    public Transform target;
    public float lerpRate;
    
    private void Update(){
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * lerpRate);
    }
}

