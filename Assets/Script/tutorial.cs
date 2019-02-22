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

    //左下スプライト変化用
    public GameObject change;

    int i = 0;
    public float time = 5f;
    private float outTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
        change = GameObject.Find("Image");  //左下スプライト変化用
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
                Debug.Log("unko");
                Light();
                change.GetComponent<ChangeSprite>().changeUtoR();   //左下スプライト変化用
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
                    Debug.Log("unko2");
                    Left();
                    change.GetComponent<ChangeSprite>().changeRtoL();   //左下スプライト変化用
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
                    Debug.Log("unko3");
                    Down();
                    change.GetComponent<ChangeSprite>().changeLtoD();   //左下スプライト変化用
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
                    Debug.Log("unko4");
                    change.GetComponent<ChangeSprite>().spriteOff();   //左下スプライト消去用
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
        Invoke("OutText", 2.0f);
    }
    void OutText()
    {
        myText.GetComponent<Text>().enabled = false;
    }
}