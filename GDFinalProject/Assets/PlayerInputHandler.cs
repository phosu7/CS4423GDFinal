using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update(){

    }

    void FixedUpdate(){
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.W)){
            vel.y = 1;
        }
        if(Input.GetKey(KeyCode.S)){
            vel.y = -1;
        }
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }
        if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        movement.MoveRB(vel);
    }
}
