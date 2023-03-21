using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Walker : MonoBehaviour {
    public enum Direction {
        Left,
        Rigth
    };

    public UnityEvent eventsOnLeftDirection;
    public UnityEvent eventsOnRightDirection;
    
    public float speed;
    public float stopDuration;


    public Transform LeftTarget;
    public Transform RigthTarget;
    public Direction direction;

    private bool isStoped;
    public Transform raycastStart;

    private void Start(){
        LeftTarget.parent = null;
        RigthTarget.parent = null;
    }

    private void Update(){
        if (isStoped == false){
            if (direction == Direction.Left){
                transform.position -= new Vector3(Time.deltaTime * speed, 0, 0);
                if (transform.position.x < LeftTarget.position.x){
                    direction = Direction.Rigth;
                    isStoped = true;
                    Invoke("IsStoped", stopDuration);
                    eventsOnLeftDirection.Invoke();
                }
            }
            else{
                transform.position += new Vector3(Time.deltaTime * speed, 0, 0);

                if (transform.position.x > RigthTarget.position.x){
                    direction = Direction.Left;
                    isStoped = true;
                    Invoke("IsStoped", stopDuration);
                    eventsOnRightDirection.Invoke();
                }
            }
        }

        RaycastHit hit;
        if (Physics.Raycast(raycastStart.position, Vector3.down,  out hit)){
            transform.position = hit.point;

        }
    }

    private void IsStoped(){
        isStoped = false;
    }
}