using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextTabako : MonoBehaviour
{
    private int value=0;
    GameObject ResultUI2_22;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_22 = GameObject.Find("ResultText2_22");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["tabako(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString(value*0.015)+"g";
        }
        Debug.Log("↓");
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            Debug.Log(DictKvp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
