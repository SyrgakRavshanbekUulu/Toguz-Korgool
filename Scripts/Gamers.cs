using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamers : MonoBehaviour
{
    public Text whiteGamer;
    public Text blackGamer;
    public GameObject panel,Iw,ib;
    public InputField whiteIn,blackIn;
    public Toggle whTog, blTog,wbotTog,bbotTog;
    public bool whG = false, blG = false, wbot = false, bbot = false;

    
    
    public void usersWhite()
    {
        Iw.SetActive(true);
        if(whiteIn.text != null)
        {
           whiteGamer.text = whiteIn.text; 
        }
        else
        {
            whiteGamer.text = "gamer 1";
        }
        
        whG = true; 
        wbot = false;
    }
    public void usersBlack()
    {
        ib.SetActive(true);
        if(blackIn.text != null)
        {
          blackGamer.text = blackIn.text; 
        }
        else
        {
          blackGamer.text = "gamer 2";  
        }
        blG = true;
        bbot = false;   
    }
    public void WhiteBot()
    {
        whiteGamer.text = "Computer";
        Iw.SetActive(false);
        whG = false;
        wbot = true;
    }
    public void BlackBot()
    {
        blackGamer.text = "Computer";
        ib.SetActive(false);
        blG = false;
        bbot = true;
    }
    public void OkButton()
    {
        if(whTog.isOn == true)
        {
          usersWhite();  
        }
        if(wbotTog.isOn == true)
        {
            WhiteBot();
        }
        if(blTog.isOn == true)
        {
            usersBlack();
        }
        if(bbotTog.isOn == true)
        {
            BlackBot();
        }
        
        panel.SetActive(false);
    }
}

