using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioForAssets : MonoBehaviour
{
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GameObject.FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        sound.Play();
    }
}
