using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{

    public Toggle fullscreenTog;
    public ResItem[] resolutions;
    public int selectedResolution;
    public Text resolutionLabel;

    public AudioMixer theMixer;

    public void ResLeft()
    {
        selectedResolution--;
        if (selectedResolution < 0)
        {
            selectedResolution = 0;
        }

        UpdateResLabel();
    }
    public void ResRight()
    {
        selectedResolution++;
        if(selectedResolution < resolutions.Length -1)
        {
            selectedResolution = resolutions.Length - 1;
        }

        UpdateResLabel();
    }



    [System.Serializable]
    public class ResItem
    {
        public int horizontal, vertical;
    }

    public void UpdateResLabel()
    {
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();
    }


    public void GraphicsApplication()
    {
        Screen.fullScreen = fullscreenTog.isOn;

    }

}
