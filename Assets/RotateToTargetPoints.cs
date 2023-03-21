using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToTargetPoints : MonoBehaviour {
    public Vector3 leftDirection;
    public Vector3 rigthDirection;
    public float rotationSpeed;
    
    public Vector3 _targetLerp;
    
    
    
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(_targetLerp),rotationSpeed* Time.deltaTime );
    }

    public void RotateLeft(){
        _targetLerp = leftDirection;
    } 
    public void RotateRight(){
        _targetLerp = rigthDirection;
    }
}
