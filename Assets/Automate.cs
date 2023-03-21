using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Automate : Gun {
    public Text bulletsText;
    public int bulletsCount;
    public PlayerArmory armory;

    public override void Shot(){
        base.Shot();
        bulletsCount -= 1;
        UpdateText();
        if (bulletsCount == 0){
            armory.TakeGunByIndex(0);
        }
    }

    public override void Activate(){
        base.Activate();
        bulletsText.enabled = true;
        UpdateText();

    }

    public override void Deactivate(){
        base.Deactivate();
        bulletsText.enabled = false;
    }

    void UpdateText(){
        bulletsText.text =  "Bullets: " + bulletsCount.ToString();
    }

    public override void AddBullets(int amountBullets){
        base.AddBullets(amountBullets);
        bulletsCount += amountBullets;
        armory.TakeGunByIndex(1);
        UpdateText();
    }
}
