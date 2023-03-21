using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab : MonoBehaviour {
    public GameObject Prefab;
    public Transform spawn;

    public void CreatePrefabShot(){
        Instantiate(Prefab, spawn.position, spawn.rotation);
    }
}