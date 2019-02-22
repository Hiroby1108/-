using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class story : MonoBehaviour
{
    bool a = false;
    Text Story;
    public GameObject rute;
    public float storyTimer = 15.0f;

    void Start()
    {
        Story = GameObject.Find("Story").GetComponentInChildren<Text>();

        Story.GetComponent<Text>().enabled = false;
        rute.gameObject.SetActive(false);
        Invoke("call", storyTimer);//ここの秒数をいじるとイベント発生時間が変わる
    }

    void Update()
    {
    }
    void call()
    {

        Story.GetComponent<Text>().enabled = true;
        rute.gameObject.SetActive(true);
        Destroy(Story, 6);//文字消す
        EventSystem.a = true;
    }
}
