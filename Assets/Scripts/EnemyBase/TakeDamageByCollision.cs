using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageByCollision : MonoBehaviour {
    public EnemyHealth enemyHealth; 
    private void OnCollisionEnter(Collision collision){
        if(gameObject.GetComponent<Rigidbody>())
        if (collision.rigidbody.GetComponent<Bullet>()){
            enemyHealth.TakeDamage(1);
        }
    }
}
