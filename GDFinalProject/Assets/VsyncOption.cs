using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VsyncOption : MonoBehaviour
{
    [SerializeField] Toggle vsyncToggle;
    // Start is called before the first frame update
    void Start()
    {
        vsyncToggle.isOn = QualitySettings.vSyncCount > 0;

        vsyncToggle.onValueChanged.AddListener(VsyncToggleChange);
    }

    public void VsyncToggleChange(bool newToggle){
        if (newToggle)
        {
            QualitySettings.vSyncCount = 1;
        }else{
            QualitySettings.vSyncCount = 0;
        }

        if (newToggle)
        {
            PlayerPrefs.SetInt("VSyncEnabled", 1);
        }else{
            PlayerPrefs.SetInt("VSyncEnabled", 0);
        }
    }
}
