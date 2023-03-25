using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V)){
            Time.timeScale = 0.2f;
        }
        else{
            Time.timeScale = 1;
        }

        Time.fixedDeltaTime  =  0.02f * Time.timeScale;
    }
}
