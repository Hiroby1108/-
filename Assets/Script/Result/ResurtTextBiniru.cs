using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResurtTextBiniru : MonoBehaviour
{
    private int value;
    GameObject ResultUI2_62;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_62 = GameObject.Find("ResultText2_62");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["Biniru(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString(value * 0.015) + "g";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}