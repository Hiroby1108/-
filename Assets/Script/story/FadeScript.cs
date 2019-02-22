using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeScript : MonoBehaviour
{
    Text myText;
    public float speed = 0.01f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;
    float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
        red = GetComponent<Text>().color.r;
        green = GetComponent<Text>().color.g;
        blue = GetComponent<Text>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().color = new Color(red, green, blue, alfa);
        alfa += speed;
            time = time + Time.deltaTime;
            if (time >= 7.0f)
            {
            myText.GetComponent<Text>().enabled = false;
            }
        }
}
