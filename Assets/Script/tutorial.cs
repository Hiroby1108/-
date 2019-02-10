using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow key was pressed.");
            myText.text = "→を入力してください";
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myText.text = "←を入力してください";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myText.text = "↓を入力してください";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myText.text = "↑を入力してください";
        }
    }
}