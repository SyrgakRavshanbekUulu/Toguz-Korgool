using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetVolume : MonoBehaviour
{

    private AudioSource music;
    private float musicVolume = 1f;
    //GameObject r = FindGameObjectsWithTag("music");
    void Start()
    {
       music = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        music.volume = musicVolume;
    }
    public void SetVolum(float vol)
    {
       musicVolume = vol;
    }
}
