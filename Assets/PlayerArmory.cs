using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmory : MonoBehaviour {
    public Gun[] guns;
    public int gunIndex;

    private void Start(){
        TakeGunByIndex(gunIndex);
    }

    public void TakeGunByIndex(int curentIndexGun){
        gunIndex = curentIndexGun;
        for (int i = 0; i < guns.Length; i++){
            if (curentIndexGun == i){
                guns[i].Activate();
            }
            else{
                guns[i].Deactivate();
            }
        }
    }

    public void AddBullets(int gunIndex, int amountBullets){
        guns[gunIndex].AddBullets(amountBullets);
        
    }
}
