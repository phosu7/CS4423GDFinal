using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTarget : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject spawnPoint;
    DeathCounter deathCounter;

    void Start(){
        deathCounter = DeathCounter.singleton;
    }
    void OnTriggerEnter2D(Collider2D other){
        target.transform.position = spawnPoint.transform.position;
        deathCounter.AddDeaths(1);
        GetComponent<AudioSource>().Play();
    }
}
