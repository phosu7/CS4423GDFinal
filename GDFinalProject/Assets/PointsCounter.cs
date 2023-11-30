using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointsCounter : MonoBehaviour
{
    public int points = 0;
    public static PointsCounter singleton;
    
    void Update(){
        string currentScene = SceneManager.GetActiveScene().name;
            if (currentScene=="TitleScreen"){ //after beating the game it sends to title screen and resets death counter
                points=0;
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

    public void AddPoints(int point){
        points += point;
    }
}
