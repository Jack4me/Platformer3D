using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour {
    public int health;
    public UnityEvent blinkDamage;

    public void TakeDamage(int damageValue){
        health -= damageValue;
        if (health <= 0){
            Die();
        }
        blinkDamage.Invoke();
    }


    public void Die(){
        Destroy(gameObject);
    }
}