using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrukaTime : MonoBehaviour{
    GameObject IrukaTimeText;
    public float time = 10.0f;
    private int t;
    public static  bool count;
    // Start is called before the first frame update
    void Start(){
        this.IrukaTimeText = GameObject.Find("Time");
        IrukaTimeText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.a == true) {
            TextDisplay();
            count = true;
        }
        if (count == true) { 
            time -= Time.deltaTime;
            t = Mathf.FloorToInt(time);
            Text uitext = GetComponent<Text>();
            uitext.text = "イルカ到達時間:" + t;
            if (time < 1){
                uitext.text = "イルカ進入中";
            }
        }
    }
    private void TextDisplay(){   //タイマー表示
        IrukaTimeText.GetComponent<Text>().enabled = true;
    }
}
