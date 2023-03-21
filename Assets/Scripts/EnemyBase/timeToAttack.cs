using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeToAttack : MonoBehaviour {
    public float counter;
    public Animator animator;
    private string TriggerName = "Attack"; 
    private void Update(){
        counter += Time.deltaTime;
        if (counter > 7){
            counter = 0;
                animator.SetTrigger(TriggerName);
        }
    }
}
