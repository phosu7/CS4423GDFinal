using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorChange : MonoBehaviour
{
    [SerializeField] SpriteRenderer ogSprite;
    [SerializeField] Sprite newSprite;
    Collider2D doorCollider;

    void Awake(){
        doorCollider = GetComponent<BoxCollider2D>();
    }
    public void ChangeDoorSprite(){
        ogSprite = gameObject.GetComponent<SpriteRenderer>();
        ogSprite.sprite = newSprite;
        doorCollider.isTrigger = true;
    }
}
