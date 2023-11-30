using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathDisplay : MonoBehaviour
{
    private Text deathText;

    // Start is called before the first frame update
    void Start()
    {
        deathText = GetComponent<Text>();
        UpdateDeathText();        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDeathText();
    }

    void UpdateDeathText(){
        if (deathText != null && DeathCounter.singleton != null){
            deathText.text = "Deaths: " + DeathCounter.singleton.deaths;
            
        }
    }
}
