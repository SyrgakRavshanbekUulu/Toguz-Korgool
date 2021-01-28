using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    
    public Text whiteGamerShot,blackGamerShot,woner;
    void Update()
    {
        whiteGamerShot.text = GetComponent<startPlay>().Kaz1Size.ToString();
        blackGamerShot.text = GetComponent<startPlay>().Kaz2Size.ToString();
    }



}
