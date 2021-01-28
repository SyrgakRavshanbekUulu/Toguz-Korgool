using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static bgAudio instanse = null;
    private static bgAudio Instanse
    {
        get { return instanse; }
    }

    void Awake()
    {
        if(instanse != null && instanse != this)
        {
           Destroy(this.gameObject);
           return;
        }
        else
        {
           instanse = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        
    }
}
