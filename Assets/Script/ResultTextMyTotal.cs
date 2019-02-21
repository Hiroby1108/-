using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextMyTotal : MonoBehaviour
{
    private int valueP, valueT;
    GameObject ResultUI1_1;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI1_1 = GameObject.Find("ResultText1_1");
        Text uitext = GetComponent<Text>();

        valueP = PlayeGetItem.getTrashList()["Petbotol(Clone)"];
        valueT = PlayeGetItem.getTrashList()["tabako(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString((valueP *0.000015)+(valueT*0.03)) + "kg";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}