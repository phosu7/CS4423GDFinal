using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 60f;
    [SerializeField] float endDegree = 90f;
    [SerializeField] float startDegree = 45f;
    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0,0, Mathf.PingPong(Time.time * rotationSpeed, endDegree) - startDegree);
    }
}
