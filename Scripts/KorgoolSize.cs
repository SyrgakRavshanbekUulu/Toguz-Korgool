using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorgoolSize : MonoBehaviour
{ 
    public GameObject[] f1,f2,f3,f4,f5,f6,f7,f8,f9,f10,f11,f12,f13,f14,f15,f16,f17,f18,k1,k2;
    public GameObject[] Numbers = new GameObject[10];
    int[] Size = new int[18];
    public GameObject ok;
   

    void Start()
    {
        Size = GetComponent<startPlay>().maxE;
        f9 = MakeSize(Size[0], new Vector3(17.6f, 4.5f, -6.6f), new Vector3(17.4f, 4.5f, -7.8f), Quaternion.Euler(-60, 280, 0));
        f8 = MakeSize(Size[1], new Vector3(15.3f, 4.5f, -13f), new Vector3(14.8f, 4.5f, -14f), Quaternion.Euler(-60, 300, 0));
        f7 = MakeSize(Size[2], new Vector3(11.4f, 4.5f, -18f), new Vector3(10.5f, 4.5f, 18.9f), Quaternion.Euler(-60, 320, 0));
        f6 = MakeSize(Size[3], new Vector3(6.3f, 4.5f, -21.7f), new Vector3(5.2f, 4.5f, -22.2f), Quaternion.Euler(-60, 340, 0));
        f5 = MakeSize(Size[4], new Vector3(0.6f, 4.5f, -23.1f), new Vector3(-0.6f, 4.5f, -231f), Quaternion.Euler(-60, 0, 0));
        f4 = MakeSize(Size[5], new Vector3(-5f, 4.5f, -22.4f), new Vector3(-6f, 4.5f, -22f), Quaternion.Euler(-60, 20, 0));
        f3 = MakeSize(Size[6], new Vector3(-10.5f, 4.5f, -19f), new Vector3(-11.4f, 4.5f, -18.2f), Quaternion.Euler(-60, 40, 0));
        f2 = MakeSize(Size[7], new Vector3(-14.7f, 4.5f, -14.1f), new Vector3(-15.3f, 4.5f, -13.1f), Quaternion.Euler(-60, 50, 0));
        f1 = MakeSize(Size[8], new Vector3(-17.4f, 4.5f, -8.2f), new Vector3(-17.7f, 4.5f, -7.1f), Quaternion.Euler(-60, 70, 0));
        f18 = MakeSize(Size[9], new Vector3(-17.6f, 4.5f, 6.6f), new Vector3(-17.3f, 4.5f, 7.3f), Quaternion.Euler(-60, 100, 0));
        f17 = MakeSize(Size[10], new Vector3(-15.3f, 4.5f, 12.8f), new Vector3(-14.5f, 4.5f, 14f), Quaternion.Euler(-60, 120, 0));
        f16 = MakeSize(Size[11], new Vector3(-11.4f, 4.5f, 18f), new Vector3(-10.5f, 4.5f, 18.8f), Quaternion.Euler(-60, 145, 0));
        f15 = MakeSize(Size[12], new Vector3(-6.3f, 4.5f, 21.3f), new Vector3(-5.0f, 4.5f, 21.8f), Quaternion.Euler(-60, 160, 0));
        f14 = MakeSize(Size[13], new Vector3(-0.6f, 4.5f, 22.8f), new Vector3(0.6f, 4.5f, 22.8f), Quaternion.Euler(-60, 180, 0));
        f13 = MakeSize(Size[14], new Vector3(4.9f, 4.5f, 22.1f), new Vector3(6.1f, 4.5f, 21.9f), Quaternion.Euler(-60, 190, 0));
        f12 = MakeSize(Size[15], new Vector3(10.5f, 4.5f, 19f), new Vector3(11.6f, 4.5f, 18.3f), Quaternion.Euler(-60, 200, 0));
        f11 = MakeSize(Size[16], new Vector3(14.7f, 4.5f,13.9f), new Vector3(15.4f, 4.5f, 12.9f), Quaternion.Euler(-60, 230, 0));
        f10 = MakeSize(Size[17], new Vector3(17.4f, 4.5f, 8f), new Vector3(-17.7f, 4.5f, 6.9f), Quaternion.Euler(-60, 250, 0));
        k2 = MakeSize(GetComponent<startPlay>().Kaz1Size, new Vector3(13.0f, 4.58f, -1.0f), new Vector3(14.3f, 4.58f, -1.0f), Quaternion.Euler(-90, 180, 0));
        k1 = MakeSize(GetComponent<startPlay>().Kaz2Size, new Vector3(-13.0f, 4.58f, 1.0f), new Vector3(-14.3f, 4.58f, 1.0f), Quaternion.Euler(-90, 0, 0));

        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit het;
            Ray rey =  Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(rey, out het, 100.0f))
            {   
                if(het.transform.gameObject == ok)
                {
                    Buzuu(f9);
                    f9 = MakeSize(GetComponent<startPlay>().maxE[8], new Vector3(17.6f, 4.5f, -6.6f), new Vector3(17.4f, 4.5f, -7.8f), Quaternion.Euler(-60, 280, 0));
                    Buzuu(f8);
                    f8 = MakeSize(GetComponent<startPlay>().maxE[7], new Vector3(15.3f, 4.5f, -13f), new Vector3(14.8f, 4.5f, -14f), Quaternion.Euler(-60, 300, 0));
                    Buzuu(f7);
                    f7 = MakeSize(GetComponent<startPlay>().maxE[6], new Vector3(11.4f, 4.5f, -18f), new Vector3(10.5f, 4.5f, -18.9f), Quaternion.Euler(-60, 320, 0));
                    Buzuu(f6);
                    f6 = MakeSize(GetComponent<startPlay>().maxE[5], new Vector3(6.3f, 4.5f, -21.7f), new Vector3(5.2f, 4.5f, -22.2f), Quaternion.Euler(-60, 340, 0));
                    Buzuu(f5);
                    f5 = MakeSize(GetComponent<startPlay>().maxE[4], new Vector3(0.6f, 4.5f, -23.1f), new Vector3(-0.6f, 4.5f, -23.1f), Quaternion.Euler(-60, 0, 0));
                    Buzuu(f4);
                    f4 = MakeSize(GetComponent<startPlay>().maxE[3], new Vector3(-5f, 4.5f, -22.4f), new Vector3(-6f, 4.5f, -22f), Quaternion.Euler(-60, 20, 0));
                    Buzuu(f3);
                    f3 = MakeSize(GetComponent<startPlay>().maxE[2], new Vector3(-10.5f, 4.5f, -19f), new Vector3(-11.4f, 4.5f, -18.2f), Quaternion.Euler(-60, 40, 0));
                    Buzuu(f2);
                    f2 = MakeSize(GetComponent<startPlay>().maxE[1], new Vector3(-14.7f, 4.5f, -14.1f), new Vector3(-15.3f, 4.5f, -13.1f), Quaternion.Euler(-60, 50, 0));
                    Buzuu(f1);
                    f1 = MakeSize(GetComponent<startPlay>().maxE[0], new Vector3(-17.4f, 4.5f, -8.2f), new Vector3(-17.7f, 4.5f, -7.1f), Quaternion.Euler(-60, 70, 0));
                    Buzuu(f18);
                    f18 = MakeSize(GetComponent<startPlay>().maxE[17], new Vector3(-17.6f, 4.5f, 6.6f), new Vector3(-17.3f, 4.5f, 7.3f), Quaternion.Euler(-60, 100, 0));
                    Buzuu(f17);
                    f17 = MakeSize(GetComponent<startPlay>().maxE[16], new Vector3(-15.3f, 4.5f, 12.8f), new Vector3(-14.5f, 4.5f, 14f), Quaternion.Euler(-60, 120, 0));
                    Buzuu(f16);
                    f16 = MakeSize(GetComponent<startPlay>().maxE[15], new Vector3(-11.4f, 4.5f, 18f), new Vector3(-10.5f, 4.5f, 18.8f), Quaternion.Euler(-60, 145, 0));
                    Buzuu(f15);
                    f15 = MakeSize(GetComponent<startPlay>().maxE[14], new Vector3(-6.3f, 4.5f, 21.3f), new Vector3(-5.0f, 4.5f, 21.8f), Quaternion.Euler(-60, 160, 0));
                    Buzuu(f14);
                    f14 = MakeSize(GetComponent<startPlay>().maxE[13], new Vector3(-0.6f, 4.5f, 22.8f), new Vector3(0.6f, 4.5f, 22.8f), Quaternion.Euler(-60, 180, 0));
                    Buzuu(f13);
                    f13 = MakeSize(GetComponent<startPlay>().maxE[12], new Vector3(4.9f, 4.5f, 22.1f), new Vector3(6.1f, 4.5f, 21.9f), Quaternion.Euler(-60, 190, 0));
                    Buzuu(f12);
                    f12 = MakeSize(GetComponent<startPlay>().maxE[11], new Vector3(10.5f, 4.5f, 19f), new Vector3(11.6f, 4.5f, 18.3f), Quaternion.Euler(-60, 200, 0));
                    Buzuu(f11);
                    f11 = MakeSize(GetComponent<startPlay>().maxE[10], new Vector3(14.7f, 4.5f,13.9f), new Vector3(15.4f, 4.5f, 12.9f), Quaternion.Euler(-60, 230, 0));
                    Buzuu(f10);
                    f10 = MakeSize(GetComponent<startPlay>().maxE[9], new Vector3(17.4f, 4.5f, 8f), new Vector3(17.7f, 4.5f, 6.9f), Quaternion.Euler(-60, 250, 0));
                    Buzuu(k2);
                    k2 = MakeSize(GetComponent<startPlay>().Kaz1Size, new Vector3(13.0f, 4.58f, -1.0f), new Vector3(14.3f, 4.58f, -1.0f), Quaternion.Euler(-90, 180, 0));
                    Buzuu(k1);
                    k1 = MakeSize(GetComponent<startPlay>().Kaz2Size, new Vector3(-13.0f, 4.58f, 1.0f), new Vector3(-14.3f, 4.58f, 1.0f), Quaternion.Euler(-90, 0, 0));
                }
            }
        }
        
    }
    public GameObject[] MakeSize(int I, Vector3 v1, Vector3 v2, Quaternion q)
    {
        GameObject[] g = new GameObject[2];
        if(I < 10)
        {
            g[0] = Instantiate(Numbers[I], v1, q);
        }
        else if(I < 20)
        {
            g[0] = Instantiate(Numbers[1], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2,q);
        }
        else if(I < 30)
        {
            g[0] = Instantiate(Numbers[2], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 40)
        {
            g[0] = Instantiate(Numbers[3], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 50)
        {
            g[0] = Instantiate(Numbers[4], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 60)
        {
            g[0] = Instantiate(Numbers[5], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 70)
        {
            g[0] = Instantiate(Numbers[6], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 80)
        {
            g[0] = Instantiate(Numbers[7], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 90)
        {
            g[0] = Instantiate(Numbers[8], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        else if(I < 100)
        {
            g[0] = Instantiate(Numbers[9], v1, q);
            g[1] = Instantiate(Numbers[I%10], v2, q);
        }
        
        return g;
    }
    public void Buzuu(GameObject[] g)
    {
        if(g[0] != null)
        Destroy(g[0]);
        if(g[1] != null)
        Destroy(g[1]);
    }
    
    
}
