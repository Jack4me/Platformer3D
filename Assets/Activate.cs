using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnemy : MonoBehaviour {
    public Transform playerTransform;
    public List<AppearanceEnemy> enemyActivate = new List<AppearanceEnemy>();

    private void Update(){
        for (int i = 0; i < enemyActivate.Count; i++){
            enemyActivate[i].CheckDistance(playerTransform.position);
        }
    }
}
