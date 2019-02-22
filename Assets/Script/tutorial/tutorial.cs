using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    Text myText;
    public GameObject cam;
    bool a = false;
    bool b = false;
    bool c = false;
    bool d = false;

    int i = 0;
    public float time = 5f;
    private float outTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        SceneFade.FadeIn();
        myText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        outTime += Time.deltaTime;
        Vector3 r = cam.gameObject.transform.eulerAngles;
        Debug.Log(r);
        if (r.x > 180f)
            r.x = r.x - 360f;

        if (r.y > 180f)
            r.y = r.y - 360f;

        if (r.x < -40f)
        {
            if (!a)
            {
                a = true;
                Light();
                i = 1;

            }
        }
        if (i == 1)
        {
            if (r.y > 55f)
            {
                if (!b)
                {
                    b = true;
       
                    Left();
                    i = 2;
                }
            }
        }
        if (i == 2)
        {
            if (r.y < -5f)
            {
                if (!c)
                {
                    c = true;
   
                    Down();
                    i = 3;
                }
            }
        }
        if (i == 3)
        {
            if (r.x > 45f)
            {
                if (!d)
                {
                    d = true;
                  
                    trash();
                }
            }
        }
    }
    void Light()
    {
        myText.text = "右を向いてください";
    }
    void Left()
    {
        myText.text = "左を向いてください";
    }
    void Down()
    {
        myText.text = "下を向いてください";
    }
    void trash()
    {
        myText.text = "ゴミを3個集めてください";
        Invoke("OutText", 4.0f);
    }
    void OutText()
    {
        myText.GetComponent<Text>().enabled = false;
    }
}