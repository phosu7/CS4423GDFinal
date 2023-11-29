using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsWindow : MonoBehaviour
{
    public void Show(){
        GetComponent<Canvas>().enabled = true;
    }

    public void Hide(){
        GetComponent<Canvas>().enabled = false;
    }
}
