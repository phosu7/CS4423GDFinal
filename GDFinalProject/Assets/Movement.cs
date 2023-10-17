using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 4;
    Rigidbody2D rb;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveRB(Vector3 vel){  
        rb.velocity = vel*speed;
        if (vel.magnitude > 0){
            animationStateChanger.ChangeAnimationState("Walk", speed/4);

            if(vel.x > 0){
                body.localScale = new Vector3(1,1,1);
            }else if (vel.x < 0){
                body.localScale = new Vector3(-1,1,1);
            }


        }else{
            animationStateChanger.ChangeAnimationState("Idle");
        }
    }
}
