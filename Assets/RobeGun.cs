using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public enum RobeState {
    Disable,
    Fly,
    Active
}

public class RobeGun : MonoBehaviour {
    public Transform spawn;
    public Hook hook;
    public float speed;
    public Collider playerColl;
    public Collider bulletColl;
    public SpringJoint _springJoint;

    public Transform RobeStart;
    public float _length;
    public RobeState curentRobeState;
    public RobeRenderer lineRenderer;
    public PlayerMovement playerMovement;

    private void Start(){
        Physics.IgnoreCollision(playerColl, bulletColl);
    }

    private void Update(){
        if (Input.GetMouseButtonDown(2)){
            Shot();
        }

        if (curentRobeState == RobeState.Fly){
            float distance = Vector3.Distance(RobeStart.position, hook.transform.position);
            {
                hook.gameObject.SetActive(false);
                curentRobeState = RobeState.Disable;
                lineRenderer.DisableRobeLine();
            }
            if (distance > 20){
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            if (curentRobeState == RobeState.Active){
                if (playerMovement.isGround == false){
                    playerMovement.Jump();
                }
            }

            DisableRobe();
        }

        if (curentRobeState == RobeState.Fly || curentRobeState == RobeState.Active){
            lineRenderer.Draw(RobeStart.position, hook.transform.position, _length);
        }
    }


    public void Shot(){
        _length = 1f;
        if (_springJoint){
            Destroy(_springJoint);

        }
        curentRobeState = RobeState.Fly;
        hook.gameObject.SetActive(true);
        hook.StopFix();
        hook.transform.position = spawn.position;
        hook.transform.rotation = spawn.rotation;
        hook.rigidbodyHook.velocity = spawn.forward * speed;
    }

    public void CreateRobeSpring(){
        if (_springJoint == null){
            curentRobeState = RobeState.Active;
            _springJoint = gameObject.AddComponent<SpringJoint>();
            _springJoint.anchor = RobeStart.localPosition;
            _springJoint.connectedBody = hook.rigidbodyHook;
            _springJoint.connectedAnchor = Vector3.zero;
            _springJoint.spring = 100;
            _springJoint.damper = 5;
            _springJoint.autoConfigureConnectedAnchor = false;
            _length = Vector3.Distance(RobeStart.position, hook.transform.position);
            _springJoint.maxDistance = _length;
        }
    }

    public void DisableRobe(){
        if (_springJoint){
            Destroy(_springJoint);
            curentRobeState = RobeState.Disable;
            hook.gameObject.SetActive(false);
            lineRenderer.DisableRobeLine();
        }
    }
}