using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health;


    public void TakeDamage(int damageValue){
        health -= damageValue;
        if (health <= 0){
            Die();
        }
    }


    public void Die(){
        Destroy(gameObject);
    }
}