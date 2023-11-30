using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    public int points = 0;
    public static PointsCounter singleton;

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
