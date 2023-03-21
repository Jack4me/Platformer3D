using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


public class PlayerHealth : MonoBehaviour {
    public int health;
    public int maxHealth = 8;
    private bool invulnerble;
    public AudioSource AddHeath;
    public HealthUI healthUI;
    // public AudioSource takeDamage;
    // public DamageUI damageImage;
    // public Blink blinkBody;

    public UnityEvent EventOnTakeDamage;

    private void Start(){
        healthUI.CountOfHealth(maxHealth);
        healthUI.ShowHealth(health);
      
    }

    public void TakeDamage(int damageValue){
        if (invulnerble == false){
            health -= damageValue;
            if (health <= 0){
                health = 0;
                Die();
            }

            invulnerble = true;
            Invoke("Invulnerble", 1f);
            healthUI.ShowHealth(health);
            // takeDamage.Play();
            // damageImage.StartCoroutine();
            // blinkBody.StartBlinkCoroutine();
            EventOnTakeDamage.Invoke();
        }
    }

    public void AddHealth(int maxPoint){
        health += maxPoint;
        if (health >= maxHealth){
            health = maxHealth;
        }

        AddHeath.Play();
        healthUI.ShowHealth(health);
    }

    void Invulnerble(){
        invulnerble = false;
    }

    public void Die(){
        Debug.Log("Player Die");
    }
}