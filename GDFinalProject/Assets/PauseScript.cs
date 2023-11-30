using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        } 
    }

    void TogglePause(){
        isPaused = !isPaused;
        
        if (isPaused){
            Time.timeScale = 0f;
        }else{
            Time.timeScale = 1f;
        }

    }
}
