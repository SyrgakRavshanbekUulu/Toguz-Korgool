using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextMove : MonoBehaviour
{
    private float f = -434.0f;
    public Text t;
    void Start()
    {
       // t = GetComponent<Text>();
    }
    public void TextUp()
    {
        if(t.transform.position.y > -48.0f)
        t.transform.Translate(0, -300.0f * Time.deltaTime, 0);
    }
    public void TextDown()
    {
        if(t.transform.position.y < 80.0f)
        t.transform.Translate(0, 300.0f * Time.deltaTime, 0);
        //t.transform.position = new Vector3(0.9f, f - 1.0f, 0);
    }
    public void SceneMain()
  {
    SceneManager.LoadScene("MainScene");
  }
}
