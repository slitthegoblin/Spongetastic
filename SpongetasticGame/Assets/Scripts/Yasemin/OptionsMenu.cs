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

    public Slider masterSlider, musicSlider, sfxSlider;
    public Text masterLabel, musicLabel, sfxLabel;

    public AudioSource sfxLoop;


    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            theMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
            masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");

        }
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            theMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");

        }
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            theMixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));
            sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        }

        masterLabel.text = (masterSlider.value + 80).ToString();
        musicLabel.text = (musicSlider.value + 80).ToString();
        sfxLabel.text = (sfxSlider.value + 80).ToString();

    }


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


    public void SetMasterVol()
    {
        masterLabel.text = (masterSlider.value + 80).ToString(); 

        theMixer.SetFloat("MasterVolume", masterSlider.value);

        PlayerPrefs.SetFloat("MasterVolume", masterSlider.value);
    }
    public void SetMusicVol()
    {
        musicLabel.text = (musicSlider.value + 80).ToString();

        theMixer.SetFloat("MusicVolume", musicSlider.value);

        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
    }
    public void setSFXVol()
    {
        sfxLabel.text = (sfxSlider.value + 80).ToString();

        theMixer.SetFloat("SFXVolume", sfxSlider.value);

        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
    }

    public void PlaySFXLoop()
    {
        sfxLoop.Play();
    }
    public void StopSFXLoop()
    {
        sfxLoop.Stop();
    }





}
