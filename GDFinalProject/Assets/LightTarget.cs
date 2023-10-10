using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTarget : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject spawnPoint;
    void OnTriggerEnter2D(Collider2D other){
        target.transform.position = spawnPoint.transform.position;
    }
}
