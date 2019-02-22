using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextTaiya : MonoBehaviour
{
    private int value;
    GameObject ResultUI2_42;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_42 = GameObject.Find("ResultText2_42");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["Taiya(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString(value * 18) + "kg";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}