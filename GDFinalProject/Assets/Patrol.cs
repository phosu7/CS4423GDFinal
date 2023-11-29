using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed = 5;
    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    Transform unitRotation;
    [SerializeField] int degreeOfRotation = -180;
    void Awake(){
        unitRotation = transform;
    }

    IEnumerator Start(){
        Transform target = point1;
        while(true){
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
            if(Vector3.Distance(transform.position, target.position)<=0){
                target = target == point1 ? point2: point1;
                if (degreeOfRotation == -180){
                    degreeOfRotation += 180;
                    unitRotation.eulerAngles = new Vector3(0, degreeOfRotation, 0);
                }else{
                    degreeOfRotation -= 180;
                    unitRotation.eulerAngles = new Vector3(0, degreeOfRotation, 0);
                }

                yield return new WaitForSeconds(0.5f);
            }
            yield return null;
        }
    }
}
