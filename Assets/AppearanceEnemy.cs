using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceEnemy : MonoBehaviour {
    public float distanceToActivate = 10f;
    private bool isActive = true;

    private void Start(){
        FindObjectOfType<ActivateEnemy>().enemyActivate.Add(this);
    }

    public void CheckDistance(Vector3 playerPosition){
        float distance = Vector3.Distance(transform.position, playerPosition);
        if (isActive){
            if (distance > distanceToActivate){
                Deactivate();
            }
        }
        else{
            if (distance < distanceToActivate){
                SetActivate();
            }
        }
    }


    public void SetActivate(){
        gameObject.SetActive(true);
        isActive = true;
    }

    public void Deactivate(){
        gameObject.SetActive(false);
        isActive = false;
    }

    private void OnDestroy(){
        FindObjectOfType<ActivateEnemy>().enemyActivate.Remove(this);
    }
}