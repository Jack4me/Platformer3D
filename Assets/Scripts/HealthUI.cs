using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour {
    public GameObject healthPrefab;
    public List<GameObject> healthList = new List<GameObject>();

    public void CountOfHealth(int maxHealth){
        for (int i = 0; i < maxHealth; i++){
           GameObject newHealth = Instantiate(healthPrefab, transform);
           healthList.Add(newHealth);
        }
    }

    public void ShowHealth(int health){
       
        for (int i = 0; i < healthList.Count; i++){
            if (i < health){
                healthList[i].SetActive(true);
            Debug.Log(health);
            }
            else{
                healthList[i].SetActive(false);
            }
        }
    }
}
