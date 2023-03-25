using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour {
    private FixedJoint _fixedJoint;
    public Rigidbody rigidbodyHook;
    public RobeGun robeGun;

   

    private void OnCollisionEnter(Collision collision){
        if (_fixedJoint == null){
            _fixedJoint = gameObject.AddComponent<FixedJoint>();
            if (collision.rigidbody){
                _fixedJoint.connectedBody = collision.rigidbody;
            }
            robeGun.CreateRobeSpring();
        }
    }

    public void StopFix(){
        if (_fixedJoint){
            Destroy(_fixedJoint);
        }
    }
}