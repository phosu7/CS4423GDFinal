using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    public int deaths = 0;
    public static DeathCounter singleton;

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
