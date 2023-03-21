using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour {
    public Vector3 Speed;
    private float maxRotationSpeed = 12;

    void Start(){
        GetComponent<Rigidbody>().AddRelativeForce(Speed, ForceMode.VelocityChange);
        GetComponent<Rigidbody>().angularVelocity = new Vector3
           (Random.Range(-maxRotationSpeed, maxRotationSpeed),
            Random.Range(-maxRotationSpeed, maxRotationSpeed),
            Random.Range(-maxRotationSpeed, maxRotationSpeed));
    }
}