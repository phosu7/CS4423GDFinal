using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    public int pointsToBeAdded = 10;
    PointsCounter pointsCounter;
    [SerializeField] AudioClip coinSound;

    void Start(){
        pointsCounter = PointsCounter.singleton;
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            AudioSource.PlayClipAtPoint(coinSound,transform.position);
            pointsCounter.AddPoints(pointsToBeAdded);

            Destroy(this.gameObject);
        }
    }
}
