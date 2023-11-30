using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCounter : MonoBehaviour
{
    public int deaths = 0;
    public static DeathCounter singleton;
    int counter = 1;
    void Update(){
        string currentScene = SceneManager.GetActiveScene().name;
            if (currentScene=="FirstStage" && counter==1){  //tutorial stage reset death counter
                deaths=0;
                counter++;
            }
            if (currentScene=="TitleScreen" && counter >= 1){ //after beating the game it sends to title screen and resets death counter
                deaths=0;
                counter++;
            }

    }
    void Awake(){
        if (singleton == null){
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(this.gameObject);
        }
    }

    public void AddDeaths(int death){
        deaths += death;
    }
}
