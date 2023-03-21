using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TakeDamageByCollision : MonoBehaviour {
    public EnemyHealth enemyHealth;
    public bool dieByCollision;
    private void OnCollisionEnter(Collision collision){
        if (collision.rigidbody){
            if (collision.rigidbody.GetComponent<Bullet>()){
                enemyHealth.TakeDamage(1);
            }
        }

        if (dieByCollision){
            Destroy(gameObject);
            
        }
    }
}