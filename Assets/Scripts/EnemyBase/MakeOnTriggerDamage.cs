using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeOnTriggerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        if (other.attachedRigidbody){
            if (other.attachedRigidbody.GetComponent<PlayerHealth>()){
                other.attachedRigidbody.GetComponent<PlayerHealth>().TakeDamage(1);
            }
        }
    }
}
