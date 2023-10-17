using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    [SerializeField] GameObject flashlight;

    void Start(){
        InvokeRepeating("LightOn", 0f, 1.75f);
    }

    void LightOn(){
        flashlight.SetActive(true);
        Invoke("LightOff",1);
    }
    
    void LightOff(){
        flashlight.SetActive(false);
    } 

}
