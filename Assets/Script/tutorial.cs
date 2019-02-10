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
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 r = cam.gameObject.transform.eulerAngles;

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
            if (r.y < -55f)
            {
                if (!c)
                {
                    c = true;
                    Down();
                    i = 3;
                }
            }
        }
        if (i == 3) {
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
        myText.text = "→を入力してください";       
    }
    void Left()
    {
        myText.text = "←を入力してください";
    }
    void Down()
    {
        myText.text = "↓を入力してください";
    }
    void trash()
    {
        myText.text = "ゴミを回収してください";
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trash")
        {
            myText.text = "ゴミOK";
            Debug.Log("unko");
        }
    }
}