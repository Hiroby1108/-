using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextGyomou : MonoBehaviour
{
    private int value;
    GameObject ResultUI2_32;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_32 = GameObject.Find("ResultText2_32");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["Gyomou(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString(value * 5) + "kg";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}