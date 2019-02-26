using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextUki : MonoBehaviour
{
    private int value;
    GameObject ResultUI2_22;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_22 = GameObject.Find("ResultText2_72");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["Uki(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString(value * 0.019) + "kg";
        }
    }
}