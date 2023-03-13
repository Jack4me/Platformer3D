using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public GameObject destroyParticle;
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    private void OnCollisionEnter(Collision collision){
        Instantiate(destroyParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
