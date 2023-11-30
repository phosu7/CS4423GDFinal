using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RotateGuard : MonoBehaviour
{
    [SerializeField] float rotationWaitTime = 2f;
    [SerializeField] GameObject childObject;
    [SerializeField] int degreeOfRotation = -180;
    Transform unitRotation;
    // Start is called before the first frame update
    void Awake()
    {
        unitRotation = transform;
    }
    void Start(){
        StartCoroutine(RotateAndDisableFlash());
    }

    IEnumerator RotateAndDisableFlash(){
        while(true){
            yield return new WaitForSeconds(rotationWaitTime);
            if (degreeOfRotation == -180){
                    childObject.SetActive(false);
                    degreeOfRotation += 180;
                    unitRotation.eulerAngles = new Vector3(0, degreeOfRotation, 0);
                }else{
                    childObject.SetActive(true);
                    degreeOfRotation -= 180;
                    unitRotation.eulerAngles = new Vector3(0, degreeOfRotation, 0);
                }
        }
    }
}
