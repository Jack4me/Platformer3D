using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchAcornsSpawn : MonoBehaviour {
    public GameObject acornPrefab;
    public Transform[] spawnPoints;

    [ContextMenu("CreateAcorns")]
    public void CreateAcorns(){


        for (int i = 0; i < spawnPoints.Length; i++){
            
        Instantiate(acornPrefab, spawnPoints[i].position, spawnPoints[i].rotation );
        }
    }
}
