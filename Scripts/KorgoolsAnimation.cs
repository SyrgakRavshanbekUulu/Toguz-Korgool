/*


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startPlay : MonoBehaviour
{
    public GameObject[] HomeNumber = new GameObject[18];
    public GameObject[] Kazyna1;
    public GameObject[] Kazyna2;
    public Vector3[] KazPos1 = new Vector3[21];
    public Vector3[] KazPos2 = new Vector3[21];
    public int Kaz1Size;
    public int Kaz2Size;
    public int lastIndex, HomePosition1 = -100, HomePosition2 = -100, moveIndex;
    private float yPos = 3.7f;
    public GameObject dfg;
    private Vector3[] SelObjPos;
    public GameObject korgool;
    public GameObject[] SelObj;
    public int[] maxE = new int[18]{9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9};
    public bool bingo,whiteGamer,blackGamer;
    public Material green;
    public Material red,HomeColor;
    private Vector3[] Sector9 = new Vector3[10];
         float xSector9 = 11.5f, zSector9 = -3.6f, xS9 = 1.3f, zS9 = 0.3f;
         float XSector9 = 11.5f, ZSector9 = -5.0f;
    private Vector3[] Sector8 = new Vector3[10];
        float xSector8 = 10f, zSector8 = -8f, xS8 = 1.0f, zS8 = 0.9f;
        float XSector8 = 9.0f, ZSector8 = -9.0f;
    private Vector3[] Sector7 = new Vector3[10];
        float xSector7 = 7.1f, zSector7 = -11f, xS7 = 0.8f, zS7 = 1.2f;
        float XSector7 = 6.0f, ZSector7 = -11.9f;
    private Vector3[] Sector6 = new Vector3[10];
        float xSector6 = 4.0f, zSector6 = -13f, xS6 = 0.5f, zS6 = 1.3f;
        float XSector6 = 2.6f, ZSector6 = -13.2f;
    private Vector3[] Sector5 = new Vector3[10];
        float xSector5 = 0.7f, zSector5 = -14f, xS5 = 0.0f, zS5 = 1.4f;
        float XSector5 = -0.7f, ZSector5 = -14f;
    private Vector3[] Sector4 = new Vector3[10];
        float xSector4 = -2.9f, zSector4 = -13.8f, xS4 = 0.2f, zS4 = 1.4f;
        float XSector4 = -4.2f, ZSector4 = -13.5f;
    private Vector3[] Sector3 = new Vector3[10];
        float xSector3 = -6.3f, zSector3 = -12.0f, xS3 = 0.7f, zS3 = 1.2f;
        float XSector3 = -7.5f, ZSector3 = -11.3f;
    private Vector3[] Sector2 = new Vector3[10];
        float xSector2 = -8.6f, zSector2 = -8.7f, xS2 = 0.9f, zS2 = 1.1f;
        float XSector2 = -9.6f, ZSector2 = -7.6f;
    private Vector3[] Sector1 = new Vector3[10];
        float xSector1 = -10.6f, zSector1 = -5.0f, xS1 = 1.4f, zS1 = 0.6f;
        float XSector1 = -11.2f, ZSector1 = -3.8f;
    private Vector3[] Sector18 = new Vector3[10];
        float xSector18 = -11.5f, zSector18 = 4f, xS18 = 1.4f, zS18 = 0.3f;
        float XSector18 = -11f, ZSector18 = 5.3f;
    private Vector3[] Sector17 = new Vector3[10];
        float xSector17 = -10.0f, zSector17 = 8.0f, xS17 = 1.2f, zS17 = 0.8f;
        float XSector17 = -9.1f, ZSector17 = 9.1f;
    private Vector3[] Sector16 = new Vector3[10];
        float xSector16 = -7.3f, zSector16 = 11.1f, xS16 = 0.8f, zS16 = 1.3f;
        float XSector16 = -6.2f, ZSector16 = 11.9f;
    private Vector3[] Sector15 = new Vector3[10];
        float xSector15 = -4.1f, zSector15 = 13.2f, xS15 = 0.3f, zS15 = 1.4f;
        float XSector15 = -2.8f, ZSector15 = 13.6f;
    private Vector3[] Sector14 = new Vector3[10];
        float xSector14 = -0.7f, zSector14 = 14.1f, xS14 = 0.0f, zS14 = 1.4f;
        float XSector14 = 0.7f, ZSector14 = 14.1f;
    private Vector3[] Sector13 = new Vector3[10];
        float xSector13 = 2.8f, zSector13 = 13.6f, xS13 = 0.3f, zS13 = 1.4f;
        float XSector13 = 4.2f, ZSector13 = 13.2f;
    private Vector3[] Sector12 = new Vector3[10];
        float xSector12 = 6.1f, zSector12 = 11.7f, xS12 = 0.8f, zS12 = 1.3f;
        float XSector12 = 7.3f, ZSector12 = 10.9f;
    private Vector3[] Sector11 = new Vector3[10];
        float xSector11 = 9.0f, zSector11 = 9.1f, xS11 = 1.1f, zS11 = 0.9f;
        float XSector11 = 9.9f, ZSector11 = 8.1f;
    private Vector3[] Sector10 = new Vector3[10];
        float xSector10 = 11f, zSector10 = 5.3f, xS10 = 1.3f, zS10 = 0.5f;
        float XSector10 = 11.6f, ZSector10 = 4.0f;
    public GameObject[] Korgool1;
    public GameObject[] Korgool2;
    public GameObject[] Korgool3;
    public GameObject[] Korgool4;
    public GameObject[] Korgool5;
    public GameObject[] Korgool6;
    public GameObject[] Korgool7;
    public GameObject[] Korgool8;
    public GameObject[] Korgool9;
    public GameObject[] Korgool10;
    public GameObject[] Korgool11;
    public GameObject[] Korgool12;
    public GameObject[] Korgool13;
    public GameObject[] Korgool14;
    public GameObject[] Korgool15;
    public GameObject[] Korgool16;
    public GameObject[] Korgool17;
    public GameObject[] Korgool18;
    MeshRenderer myrend;
    
    void Start()
    {
        Sector1 = SectorPosition(xSector1,zSector1,XSector1,ZSector1,xS1,zS1);
        Sector2 = SectorPosition(xSector2,zSector2,XSector2,ZSector2,xS2,zS2);
        Sector3 = SectorPosition(xSector3,zSector3,XSector3,ZSector3,xS3,zS3);
        Sector4 = SectorPosition(xSector4,zSector4,XSector4,ZSector4,xS4,zS4);
        Sector5 = SectorPosition(xSector5,zSector5,XSector5,ZSector5,xS5,zS5);
        Sector6 = SectorPosition(xSector6,zSector6,XSector6,ZSector6,xS6,zS6);
        Sector7 = SectorPosition(xSector7,zSector7,XSector7,ZSector7,xS7,zS7);
        Sector8 = SectorPosition(xSector8,zSector8,XSector8,ZSector8,xS8,zS8);
        Sector9 = SectorPosition(xSector9,zSector9,XSector9,ZSector9,xS9,zS9);
        Sector10 = SectorPosition(xSector10,zSector10,XSector10,ZSector10,xS10,zS10);
        Sector11 = SectorPosition(xSector11,zSector11,XSector11,ZSector11,xS11,zS11);
        Sector12 = SectorPosition(xSector12,zSector12,XSector12,ZSector12,xS12,zS12);
        Sector13 = SectorPosition(xSector13,zSector13,XSector13,ZSector13,xS13,zS13);
        Sector14 = SectorPosition(xSector14,zSector14,XSector14,ZSector14,xS14,zS14);
        Sector15 = SectorPosition(xSector15,zSector15,XSector15,ZSector15,xS15,zS15);
        Sector16 = SectorPosition(xSector16,zSector16,XSector16,ZSector16,xS16,zS16);
        Sector17 = SectorPosition(xSector17,zSector17,XSector17,ZSector17,xS17,zS17);
        Sector18 = SectorPosition(xSector18,zSector18,XSector18,ZSector18,xS18,zS18);
        Korgool1 = SectorElements(Sector1, maxE[0]);
        Korgool2 = SectorElements(Sector2, maxE[1]);
        Korgool3 = SectorElements(Sector3, maxE[2]);
        Korgool4 = SectorElements(Sector4, maxE[3]);
        Korgool5 = SectorElements(Sector5, maxE[4]);
        Korgool6 = SectorElements(Sector6, maxE[5]);
        Korgool7 = SectorElements(Sector7, maxE[6]);
        Korgool8 = SectorElements(Sector8, maxE[7]);
        Korgool9 = SectorElements(Sector9, maxE[8]);
        Korgool10 = SectorElements(Sector10, maxE[9]);
        Korgool11 = SectorElements(Sector11, maxE[10]);
        Korgool12 = SectorElements(Sector12, maxE[11]);
        Korgool13 = SectorElements(Sector13, maxE[12]);
        Korgool14 = SectorElements(Sector14, maxE[13]);
        Korgool15 = SectorElements(Sector15, maxE[14]);
        Korgool16 = SectorElements(Sector16, maxE[15]);
        Korgool17 = SectorElements(Sector17, maxE[16]);
        Korgool18 = SectorElements(Sector18, maxE[17]);
        KazPos1 = Kazyna1Pos();
        KazPos2 = Kazyna2Pos();
        whiteGamer = true;
        blackGamer = false;
     } 

    void Update()
    {
        //KorgoolsMoving(not,animationPos);
        if(Kaz1Size > 81)
        {
            Debug.Log("gamer1 won");
        }
        else if(Kaz2Size > 81)
        {
            Debug.Log("gamer2 won");  
        }
        else if(Kaz2Size == 81 && Kaz1Size == 81)
        {
            Debug.Log("draw");
        }
        else if(Input.GetMouseButtonDown(0))
         {
             
             RaycastHit hit;
             Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition);
             if(Physics.Raycast(ray, out hit, 100.0f))
             {
                 //Tusun ozgortuu arkyluu belgiloo
                 if(Korgool1.Length != 0 && whiteGamer == true)
                 searching(hit.transform.gameObject, Korgool1);
                 if(Korgool2.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool2);
                 if(Korgool3.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool3);
                 if(Korgool4.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool4);
                 if(Korgool5.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool5);
                 if(Korgool6.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool6);
                 if(Korgool7.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool7);
                 if(Korgool8.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool8);
                 if(Korgool9.Length != 0 && whiteGamer == true )
                 searching(hit.transform.gameObject, Korgool9);
                 if(Korgool10.Length != 0 && blackGamer == true )
                 searching(hit.transform.gameObject, Korgool10);
                 if(Korgool11.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool11);
                 if(Korgool12.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool12);
                 if(Korgool13.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool13);
                 if(Korgool14.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool14);
                 if(Korgool15.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool15);
                 if(Korgool16.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool16);
                 if(Korgool17.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool17);
                 if(Korgool18.Length != 0 && blackGamer == true  )
                 searching(hit.transform.gameObject, Korgool18);
                 //ok knopkasynyn basylyshy
                 if(Input.GetMouseButtonDown(0))
                 {
                     RaycastHit het;
                     Ray rey =  Camera.main.ScreenPointToRay(Input.mousePosition);
                     if(Physics.Raycast(rey, out het, 100.0f))
                     {   
                        if(het.transform.gameObject == dfg && SelObj[0] != null)
                        {
                          
                          if(SelObj == Korgool1)
                          {
                              if(Korgool1.Length == 1)
                              {
                                  maxE[0] = 0;
                                  maxE[1] = maxE[1] + 1;
                                  lastIndex = 1;
                                  
                              }
                              
                              else 
                              {
                                maxE[0] = 1;
                                for(int i = 0; i < Korgool1.Length; i++)
                                {
                                  if(i == 0) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 - 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool2)
                          {
                              if(Korgool2.Length == 1)
                              {
                                 maxE[1] = 0;
                                 maxE[2] = maxE[2] + 1;
                                 lastIndex = 2;
                              }
                              else
                              {
                                maxE[1] = 1;
                                for(int i = 1; i < Korgool2.Length + 1; i++)
                                {
                                  if(i == 1) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool3)
                          {
                              if(Korgool3.Length == 1)
                              {
                                  maxE[2] = 0;
                                  maxE[3] = maxE[3] + 1;
                                  lastIndex = 3;
                              }
                              else
                              {
                                maxE[2] = 1;
                                for(int i = 2; i < Korgool3.Length + 2; i++)
                                { 
                                  if(i == 2) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool4)
                          {
                              if(Korgool4.Length == 1)
                              {
                                  maxE[3] = 0;
                                  maxE[4] = maxE[4] + 1;
                                  lastIndex = 4;
                              }
                              else
                              {
                                maxE[3] = 1;
                                for(int i = 3; i < Korgool4.Length +3; i++)
                               { 
                                  if(i == 3) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool5)
                          {
                              if(Korgool5.Length == 1)
                              {
                                  maxE[4] = 0;
                                  maxE[5] = maxE[5] + 1;
                                  lastIndex = 5;
                              }
                              else
                              {
                                maxE[4] = 1;
                                for(int i = 4; i < Korgool5.Length + 4; i++)
                                { 
                                  if(i == 4) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool6)
                          {
                              if(Korgool6.Length == 1)
                              {
                                  maxE[5] = 0;
                                  maxE[6] = maxE[6] + 1;
                                  lastIndex = 6;
                              }
                              else
                              {
                                maxE[5] = 1;
                                for(int i = 5; i < Korgool6.Length + 5; i++)
                                { 
                                  if(i == 5) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool7)
                          {
                              if(Korgool7.Length == 1)
                              {
                                  maxE[6] = 0;
                                  maxE[7] = maxE[7] + 1;
                                  lastIndex = 7;
                              }
                              else
                              {
                                maxE[6] = 1;
                                for(int i = 6; i < Korgool7.Length + 6; i++)
                                { 
                                  if(i == 6) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool8)
                          {
                              if(Korgool8.Length == 1)
                              {
                                  maxE[7] = 0;
                                  maxE[8] = maxE[8] + 1;
                                  lastIndex = 8;
                              }
                              else
                              {
                                maxE[7] = 1;
                                for(int i = 7; i < Korgool8.Length + 7; i++)
                                { 
                                  if(i == 7) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool9)
                          {
                              if(Korgool9.Length == 1)
                              {
                                  maxE[8] = 0;
                                  maxE[9] = maxE[9] + 1;
                                  lastIndex = 9;
                              }
                              else
                              {
                                maxE[8] = 1;
                                for(int i = 8; i < Korgool9.Length + 8; i++)
                                { 
                                  if(i == 8) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex > 8 )
                              {
                                  Kaz1Size = Kaz1Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex > 8 && HomePosition1 == -1 && lastIndex != 17 && lastIndex != HomePosition2 + 9)
                              {
                                  newHome();
                              }
                          }
                          else if(SelObj == Korgool10)
                          {
                              if(Korgool10.Length == 1)
                              {
                                  maxE[9] = 0;
                                  maxE[10] = maxE[10] + 1;
                                  lastIndex = 10;
                              }
                              else
                              {
                                maxE[9] = 1;
                                for(int i = 9; i < Korgool10.Length + 9; i++)
                                { 
                                  if(i == 9) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool11)
                          {
                              if(Korgool11.Length == 1)
                              {
                                  maxE[10] = 0;
                                  maxE[11] = maxE[11] + 1;
                                  lastIndex = 11;
                              }
                              else
                              {
                                maxE[10] = 1;
                                for(int i = 10; i < Korgool11.Length + 10; i++)
                                { 
                                  if(i == 10) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool12)
                          {
                              if(Korgool12.Length == 1)
                              {
                                  maxE[11] = 0;
                                  maxE[12] = maxE[12] + 1;
                                  lastIndex = 12;
                              }
                              else
                              {
                                maxE[11] = 1;
                                for(int i = 11; i < Korgool12.Length + 11; i++)
                                { 
                                  if(i == 11) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                              
                            }
                          else if(SelObj == Korgool13)
                          {
                              if(Korgool13.Length == 1)
                              {
                                  maxE[12] = 0;
                                  maxE[13] = maxE[13] + 1;
                                  lastIndex = 13;
                              }
                              else
                              {
                                maxE[12] = 1;
                                for(int i = 12; i < Korgool13.Length + 12; i++)
                                { 
                                  if(i == 12) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool14)
                          {
                              if(Korgool14.Length == 1)
                              {
                                  maxE[13] = 0;
                                  maxE[14] = maxE[14] + 1;
                                  lastIndex = 14;
                              }
                              else
                              {
                                maxE[13] = 1;
                                for(int i = 13; i < Korgool14.Length + 13; i++)
                                { 
                                  if(i == 13) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool15)
                          {
                              if(Korgool15.Length == 1)
                              {
                                  maxE[14] = 0;
                                  maxE[15] = maxE[15] + 1;
                                  lastIndex = 15;
                              }
                              else
                              {
                                maxE[14] = 1;
                                for(int i = 14; i < Korgool15.Length + 14; i++)
                                { 
                                  if(i == 14) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i - 18;
                                  }
                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool16)
                          {
                              if(Korgool16.Length == 1)
                              {
                                  maxE[15] = 0;
                                  maxE[16] = maxE[16] + 1;
                                  lastIndex = 16;
                              }
                              else
                              {
                                maxE[15] = 1;
                                for(int i = 15; i < Korgool16.Length + 15; i++)
                                { 
                                  if(i == 15) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool17)
                          {
                              if(Korgool17.Length == 1)
                              {
                                  maxE[16] = 0;
                                  maxE[17] = maxE[17] + 1;
                                  lastIndex = 17;
                              }
                              else
                              {
                                maxE[16] = 1;
                                for(int i = 16; i < Korgool17.Length + 16; i++)
                                { 
                                  if(i == 16) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i - 18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          else if(SelObj == Korgool18)
                          {
                              if(Korgool18.Length == 1)
                              {
                                  maxE[17] = 0;
                                  maxE[0] = maxE[0] + 1;
                                  lastIndex = 0;
                              }
                              else
                              {
                                maxE[17] = 1;
                                for(int i = 17; i < Korgool18.Length + 17; i++)
                                { 
                                  if(i == 17) continue;
                                  else if(i < 18)
                                  {
                                     maxE[i] = maxE[i] + 1;
                                     lastIndex = i;
                                  }
                                  else if(i >= 18)
                                  {
                                      maxE[i-18] = maxE[i-18] + 1;
                                      lastIndex = i-18;
                                  }

                                }
                              }
                              if(maxE[lastIndex] % 2 == 0 && lastIndex < 9 )
                              {
                                  Kaz2Size = Kaz2Size + maxE[lastIndex];
                                  maxE[lastIndex] = 0;
                              }
                              else if(maxE[lastIndex] == 3 && lastIndex < 8 && HomePosition2 == -1 && lastIndex != 8 && lastIndex != HomePosition1 - 9)
                              {
                                  newHome2();
                              }
                          }
                          if(HomePosition1 != -1 && maxE[HomePosition1] > 0)
                          {
                            Kaz1Size = Kaz1Size + maxE[HomePosition1];
                            maxE[HomePosition1] = 0;
                          }
                          if(HomePosition2 != -1 && maxE[HomePosition2] > 0)
                          {
                            Kaz2Size = Kaz2Size + maxE[HomePosition2];
                            maxE[HomePosition2] = 0;  
                          }
                          if(whiteGamer == true)
                          {
                            whiteGamer = false;
                            blackGamer = true;
                          }
                          else
                          {
                            whiteGamer = true;
                            blackGamer = false;
                          }
                          MoveObjects();
                          restart(Kazyna1,Kaz1Size);
                          Kazyna1 =  kraja(Kaz1Size, KazPos2);
                          restart(Kazyna2,Kaz2Size);
                          Kazyna2 =  kraja(Kaz2Size, KazPos1);
                        }
                        
                     }
                 }
             }
         }
    }

    /*public Vector3[] animPos(int stat, int size)
    {
        Vector3[] v = new Vector3[size];
        for( int i = 0; i < size; i++ )
        {
            if( i + stat < 18)
            {
                v[i] = animationPos[i + stat];
            }
            else if( i + stat < 36)
            {
                v[i] = animationPos[i + stat - 17];
            }
            else if( i + stat < 54)
            {
                v[i] = animationPos[i + stat - 35];
            }
        }
        return v;
    }*/
    /*public void KorgoolsMoving(GameObject[] g, Vector3[] v)
    {
        for(int i = 0; i < g.Length; i++)
        {
            g[i].transform.position = Vector3.MoveTowards(g[i].transform.position, v[i] , 0.2f);
           // g[i].transform.position = Vector3.MoveTowards(g[i].transform.position, g[i].transform.position + new Vector3(0,3,0), 0.5f);
           // g[i].transform.position = Vector3.MoveTowards(g[i].transform.position, v[i] + new Vector3(0,3,0), 0.5f);
           // g[i].transform.position = Vector3.MoveTowards(g[i].transform.position, v[i], 0.5f);
           
        }
        moveController = true;
    }
    public void newHome()
    {
        Kaz1Size = Kaz1Size + 3;
        maxE[lastIndex] = 0;
        HomePosition1 = lastIndex;
        HomeNumber[lastIndex].GetComponent<Renderer>().material = HomeColor;
                              
    }
    public void newHome2()
    {
        Kaz2Size = Kaz2Size + 3;
        maxE[lastIndex] = 0;
        HomePosition2 = lastIndex;
        HomeNumber[lastIndex].GetComponent<Renderer>().material = HomeColor;
    }

    public void MoveObjects()
    {
        restart(Korgool1,maxE[0]);
        restart(Korgool2,maxE[1]);
        restart(Korgool3,maxE[2]);
        restart(Korgool4,maxE[3]);
        restart(Korgool5,maxE[4]);
        restart(Korgool6,maxE[5]);
        restart(Korgool7,maxE[6]);
        restart(Korgool8,maxE[7]);
        restart(Korgool9,maxE[8]);
        restart(Korgool10,maxE[9]);
        restart(Korgool11,maxE[10]);
        restart(Korgool12,maxE[11]);
        restart(Korgool13,maxE[12]);
        restart(Korgool14,maxE[13]);
        restart(Korgool15,maxE[14]);
        restart(Korgool16,maxE[15]);
        restart(Korgool17,maxE[16]);
        restart(Korgool18,maxE[17]);
        Korgool1 = SectorElements(Sector1, maxE[0]);
        Korgool2 = SectorElements(Sector2, maxE[1]);
        Korgool3 = SectorElements(Sector3, maxE[2]);
        Korgool4 = SectorElements(Sector4, maxE[3]);
        Korgool5 = SectorElements(Sector5, maxE[4]);
        Korgool6 = SectorElements(Sector6, maxE[5]);
        Korgool7 = SectorElements(Sector7, maxE[6]);
        Korgool8 = SectorElements(Sector8, maxE[7]);
        Korgool9 = SectorElements(Sector9, maxE[8]);
        Korgool10 = SectorElements(Sector10, maxE[9]);
        Korgool11 = SectorElements(Sector11, maxE[10]);
        Korgool12 = SectorElements(Sector12, maxE[11]);
        Korgool13 = SectorElements(Sector13, maxE[12]);
        Korgool14 = SectorElements(Sector14, maxE[13]);
        Korgool15 = SectorElements(Sector15, maxE[14]);
        Korgool16 = SectorElements(Sector16, maxE[15]);
        Korgool17 = SectorElements(Sector17, maxE[16]);
        Korgool18 = SectorElements(Sector18, maxE[17]);

    }
    public void restart(GameObject[] g, int maxEl)
    {
        for(int i = 0; i < g.Length; i++)
        {
            Destroy(g[i]);
        }
        g = new GameObject[maxEl];
    }
    public void selecting(GameObject[] g, bool q) 
    {   
        Material mater;
        if(q == true) mater = green;
        else mater = red;
        for( int i = 0; i < g.Length; i++)
        {
            if(g[i] != null)
            g[i].GetComponent<Renderer>().material = mater;
        }
        
    }
    public void searching(GameObject q,GameObject[] sector)
    {
        for(int i = 0; i < sector.Length; i++)
        {
            if(q == sector[i])
            {
                bingo = true;
                break;
            }
            else
            {
                bingo = false;
            }
        }
        selecting(sector, bingo);
        if(bingo)
        SelObj = sector;
    }
    public void SelPos(GameObject[] g)
    {
        if(g[0].transform.position == Sector1[0]) SelObjPos = Sector1;
        else if(g[0].transform.position == Sector2[0]) SelObjPos = Sector2;
        else if(g[0].transform.position == Sector3[0]) SelObjPos = Sector3;
        else if(g[0].transform.position == Sector4[0]) SelObjPos = Sector4;
        else if(g[0].transform.position == Sector5[0]) SelObjPos = Sector5;
        else if(g[0].transform.position == Sector6[0]) SelObjPos = Sector6;
        else if(g[0].transform.position == Sector7[0]) SelObjPos = Sector7;
        else if(g[0].transform.position == Sector8[0]) SelObjPos = Sector8;
        else if(g[0].transform.position == Sector9[0]) SelObjPos = Sector9;
        else if(g[0].transform.position == Sector10[0]) SelObjPos = Sector10;
        else if(g[0].transform.position == Sector11[0]) SelObjPos = Sector11;
        else if(g[0].transform.position == Sector12[0]) SelObjPos = Sector12;
        else if(g[0].transform.position == Sector13[0]) SelObjPos = Sector13;
        else if(g[0].transform.position == Sector14[0]) SelObjPos = Sector14;
        else if(g[0].transform.position == Sector15[0]) SelObjPos = Sector15;
        else if(g[0].transform.position == Sector16[0]) SelObjPos = Sector16;
        else if(g[0].transform.position == Sector17[0]) SelObjPos = Sector17;
        else if(g[0].transform.position == Sector18[0]) SelObjPos = Sector18;
    }
   
    public Vector3[] SectorPosition(float xsector, float zsector, float Xsector, float Zsector, float xs, float zs)
    {
       Vector3[] Sectr = new Vector3[10];
       int al = 1;
           if(xsector > 0 && zsector < 0 && Xsector > 0 && Zsector < 0) al = 1;
           else if(xsector < 0 && zsector < 0 && Xsector < 0 && Zsector < 0) al = 2;
           else if(xsector < 0 && zsector > 0 && Xsector < 0 && Zsector > 0) al = 3;
           else if(xsector > 0 && zsector > 0 && Xsector > 0 && Zsector > 0) al = 4;
           else if(xsector > 0 && zsector < 0 && Xsector < 0 && Zsector < 0) al = 1;
           else if(xsector < 0 && zsector > 0 && Xsector > 0 && Zsector > 0) al = 3;
           for (int i = 0; i < 10; i++){
            if ( i >= 5)
            {
                if(al == 1)
                  Sectr[i] = new Vector3(Xsector + xs * (i - 5), yPos, Zsector - zs * (i - 5));
                else if(al == 2)
                  Sectr[i] = new Vector3(Xsector - xs * (i - 5), yPos, Zsector - zs * (i - 5));
                else if(al == 3)
                  Sectr[i] = new Vector3(Xsector - xs * (i - 5), yPos, Zsector + zs * (i - 5));
                else if(al == 4)
                  Sectr[i] = new Vector3(Xsector + xs * (i - 5), yPos, Zsector + zs * (i - 5));

            }
            else if(i < 5 )
            {
                if(al == 1)
                  Sectr[i] = new Vector3(xsector + xs * i, yPos, zsector - zs * i); 
                else if(al == 2)
                  Sectr[i] = new Vector3(xsector - xs * i, yPos, zsector - zs * i);
                else if(al == 3)
                  Sectr[i] = new Vector3(xsector - xs * i, yPos, zsector + zs * i);
                else if(al == 4)
                  Sectr[i] = new Vector3(xsector + xs * i, yPos, zsector + zs * i);
            }
        }
        return Sectr;
    }
    public GameObject[] SectorElements(Vector3[] secPos, int maxElement)
    {
        GameObject[] r = new GameObject[maxElement];
        for (int i = 0; i < maxElement; i++)
        {
            if(i < 10)
            r[i] = Instantiate(korgool, secPos[i], Quaternion.identity) as GameObject;  
            else if(i >= 10)
            {
                r[i] = Instantiate(korgool, secPos[i - 10], Quaternion.identity) as GameObject; 
            }
            else if(i >= 20)
            {
                r[i] = Instantiate(korgool, secPos[i - 20], Quaternion.identity) as GameObject;
            }
        }
        return r;
    }
    public GameObject[] kraja(int kazynasize, Vector3[] v)
    {
        GameObject[] g = new GameObject[kazynasize];
        for( int i = 0; i < kazynasize; i++)
        {
            
            if(i < 21)
            {
                g[i] = Instantiate(korgool,v[i],Quaternion.identity) as GameObject;
            }
            else if(i < 42)
            {
                g[i] = Instantiate(korgool,v[i-21],Quaternion.identity) as GameObject;
            }
            else if(i < 63)
            {
                g[i] = Instantiate(korgool,v[i - 42],Quaternion.identity) as GameObject;
            }
            else 
            {
                g[i] = Instantiate(korgool,v[i - 63],Quaternion.identity) as GameObject;
            }
                
        }
        return g;
    }
    public Vector3[] Kazyna1Pos()
    {
        Vector3[] KazPo = new Vector3[21];
       for( int i = 0; i < 21; i++)
       {
           if(i < 3)
           {
               KazPo[i] = new Vector3( -3.0f - i * 1.2f, yPos, 1.7f + i * 0.4f);
           }
           else if(i < 6)
           {
               KazPo[i] = new Vector3(-2.2f - 1.1f * (i-3), yPos, 2.7f + 0.9f * (i-3));
           }
           else if(i < 9)
           {
               KazPo[i] = new Vector3(-1.1f - 0.9f * (i-6), yPos, 3.5f + 1.1f * (i-6));
           }
           else if(i < 12)
           {
               KazPo[i] = new Vector3(0.2f + 0.0f * (i-9), yPos, 4.0f + 1.4f * (i-9));
           }
           else if(i < 15)
           {
               KazPo[i] = new Vector3(1.4f + 0.8f * (i-12), yPos, 3.5f + 1.2f * (i-12));
           }
           else if(i < 18)
           {
               KazPo[i] = new Vector3(2.3f + 1.0f * (i-15), yPos, 2.7f + 1.0f * (i-15));
           }
           else 
           {
               KazPo[i] = new Vector3(2.8f + 1.2f * (i-18), yPos, 1.5f + 0.5f * (i-18));
           }
       }
       return KazPo;

    }
    public Vector3[] Kazyna2Pos()
    {
        Vector3[] KazPo = new Vector3[21];
       for( int i = 0; i < 21; i++)
       {
           if(i < 3)
           {
               KazPo[i] = new Vector3( 3.0f + i * 1.2f, yPos, -1.7f - i * 0.4f);
           }
           else if(i < 6)
           {
               KazPo[i] = new Vector3(2.2f + 1.1f * (i-3), yPos, -2.7f - 0.9f * (i-3));
           }
           else if(i < 9)
           {
               KazPo[i] = new Vector3(1.1f + 0.9f * (i-6), yPos, -3.5f - 1.1f * (i-6));
           }
           else if(i < 12)
           {
               KazPo[i] = new Vector3(-0.2f - 0.0f * (i-9), yPos, -4.0f - 1.4f * (i-9));
           }
           else if(i < 15)
           {
               KazPo[i] = new Vector3(-1.4f - 0.8f * (i-12), yPos, -3.5f - 1.2f * (i-12));
           }
           else if(i < 18)
           {
               KazPo[i] = new Vector3(-2.3f - 1.0f * (i-15), yPos, -2.7f - 1.0f * (i-15));
           }
           else 
           {
               KazPo[i] = new Vector3(-2.8f - 1.2f * (i-18), yPos, -1.5f - 0.5f * (i-18));
           }
       }
       return KazPo;

    }

}*/


