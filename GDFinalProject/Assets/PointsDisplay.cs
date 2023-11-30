using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    private Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        pointText = GetComponent<Text>();
        UpdatePointText();        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePointText();
    }

    void UpdatePointText(){
        if (pointText != null && PointsCounter.singleton != null){
            pointText.text = "Points: " + PointsCounter.singleton.points;
            
        }
    }
}
