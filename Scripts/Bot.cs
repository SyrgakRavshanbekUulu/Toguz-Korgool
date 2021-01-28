using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bot : MonoBehaviour
{
    public int[] SecSize = new int[18];
    public int wbotAttak,bbotAttak;
    void Update()
    {
        SecSize = GetComponent<startPlay>().maxE;
        
        //bbotAttak = bmaxPoint();
        //wbotAttak = wmaxPoint();
        
    }
    public int botPointIndex(int numberSector, int sectorSize)
    {
        int  pointIndex = -1;
        if(numberSector + sectorSize - 1 < 18)
        {
            pointIndex = numberSector + sectorSize - 1;
        }
        else if(sectorSize + numberSector - 1 < 36)
        {
            pointIndex = sectorSize + numberSector - 1 - 18;
        }
        else if(sectorSize + numberSector - 1 < 54)
        {
            pointIndex = sectorSize + numberSector - 37;
        }
        
        return pointIndex;
    }
    public int bmaxPoint()
    {
        int max = -1;
        int maxPointIndex = -1;
        for( int i = 9; i < 18; i++ )
        {
            if(SecSize[botPointIndex(i, SecSize[i])]  == 2 && SecSize[botPointIndex(i, SecSize[i])] > max && SecSize[i] != 0 && botPointIndex(i, SecSize[i]) < 9)
            {
                maxPointIndex = i;
            }
            else if(SecSize[botPointIndex(i, SecSize[i])] % 2 == 1 && SecSize[botPointIndex(i, SecSize[i])] > max && SecSize[i] != 0 && botPointIndex(i, SecSize[i]) < 9)
            {
                max = SecSize[botPointIndex(i, SecSize[i])];
                maxPointIndex = i;
            }
        }
        if(maxPointIndex == -1)
        {
            for(int i = 9; i < 18; i++)
            {
                if(SecSize[i] > 0 && max < SecSize[i])
                {
                    max = SecSize[i];
                    maxPointIndex = i;
                }
            }
        }
        return maxPointIndex;
    }
    public int wmaxPoint()
    {
        int max = -1;
        int maxPointIndex = -1;
        for(int i = 0; i < 9; i++)
        {
            if(SecSize[0] != 0){
            if(SecSize[botPointIndex(i, SecSize[i])] == 2 && SecSize[botPointIndex(i, SecSize[i])] > max && SecSize[i] != 0 && botPointIndex(i, SecSize[i]) > 8)
            {
                maxPointIndex = i;
            }
            else if(SecSize[botPointIndex(i, SecSize[i])] % 2 == 1 && SecSize[botPointIndex(i, SecSize[i])] > max && SecSize[i] != 0 && botPointIndex(i, SecSize[i]) > 8)
            {
                max = SecSize[botPointIndex(i, SecSize[i])];
                maxPointIndex = i;
            }
            }
        }
        if(maxPointIndex == -1)
        {
            for(int i = 0; i < 9; i++)
            {
                if(SecSize[i] > 0 && max < SecSize[i])
                {
                    max = SecSize[i];
                    maxPointIndex = i;
                }
            }
        }
        return maxPointIndex;
    }
    
}
