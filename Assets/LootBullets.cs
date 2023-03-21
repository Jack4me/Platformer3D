using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBullets : MonoBehaviour {
    public int gunIndex;
    public int amountBullets;
    private void OnTriggerEnter(Collider other){
        if (other.attachedRigidbody.GetComponent<PlayerArmory>()){
            other.attachedRigidbody.GetComponent<PlayerArmory>().AddBullets(gunIndex, amountBullets);
            Destroy(gameObject);
        }
    }
}
