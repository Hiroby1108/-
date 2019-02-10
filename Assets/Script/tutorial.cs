using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    Text myText;
   public GameObject cam;
    int a=0;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = gameObject.transform.eulerAngles;
        if (rot.x<-40)
        {
            Debug.Log("unko");
            call();
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
    void call()
    {
            myText.text = "→を入力してください";
    }
}