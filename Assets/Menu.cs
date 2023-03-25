using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject menuButton;
    public GameObject OpenMenuWindow;
    public MonoBehaviour[] scriptsToDisable;
    
    public void OpenMenu(){
        OpenMenuWindow.SetActive(true);
        menuButton.SetActive(false);

        for (int i = 0; i < scriptsToDisable.Length; i++){
            scriptsToDisable[i].enabled = false;
        }
    }

    public void BackToGame(){
        OpenMenuWindow.SetActive(false);
        menuButton.SetActive(true);
        for (int i = 0; i < scriptsToDisable.Length; i++){
            scriptsToDisable[i].enabled = true;
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}