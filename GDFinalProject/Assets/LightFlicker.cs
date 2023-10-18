using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    [SerializeField] GameObject flashlight;
    [SerializeField] float timeOn = 1.75f;
    [SerializeField] float timeOff = 1;
    void Start(){
        InvokeRepeating("LightOn", 0f, timeOn);
    }

    void LightOn(){
        flashlight.SetActive(true);
        Invoke("LightOff",timeOff);
    }
    
    void LightOff(){
        flashlight.SetActive(false);
    } 

}
