using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyToOpen : MonoBehaviour
{
    public DoorChange doorChangeScript;

    void OnTriggerEnter2D(Collider2D other){
        doorChangeScript.ChangeDoorSprite();
        Destroy(this.gameObject);
    }

}
