using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour {
    public Image damage;

    public void StartCoroutineDamage(){
        StartCoroutine("DamageApear");
    }

    public IEnumerator DamageApear(){
        damage.enabled = true;
        for (float t = 1; t > 0; t -=Time.deltaTime){
            damage.color = new Color(1f, 0f, 1f, t);
            yield return null;
        }

        damage.enabled = false;
    }
}