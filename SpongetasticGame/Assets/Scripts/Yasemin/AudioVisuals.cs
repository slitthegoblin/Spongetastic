using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisuals : MonoBehaviour
{

    private static AudioVisuals audioVisuals;

    void Awake()
    {
        if(audioVisuals == null)
        {
            audioVisuals = this;
            DontDestroyOnLoad(audioVisuals);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
