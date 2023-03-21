using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOnTriggerDamage : MonoBehaviour {
    public EnemyHealth enemyHealth;
    public bool dieByCollision;

    private void OnTriggerEnter(Collider other){
        if (other.attachedRigidbody){
            if (other.attachedRigidbody.GetComponent<Bullet>()){
                enemyHealth.TakeDamage(1);
            }
        }

        if (dieByCollision){
            if (other.isTrigger == false){
                enemyHealth.TakeDamage(1000);
            }
        }
    }
}