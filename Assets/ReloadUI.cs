using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReloadUI : MonoBehaviour {
    public Image foreground;
    public Image background;
    public Text counterText;


    public void StartCharge(){
        background.color = new Color(1, 1, 1, 0.3f);
        foreground.enabled = true;
        counterText.enabled = true;
    }

    public void StopCharge(){
        foreground.enabled = false;
        counterText.enabled = false;
        background.color = new Color(1, 1, 1, 1f);
    }

    public void SetCharge(float curentCharge, float maxCharge){
        foreground.fillAmount = curentCharge / maxCharge;
        counterText.text = Mathf.Ceil(maxCharge - curentCharge).ToString();
    }
}