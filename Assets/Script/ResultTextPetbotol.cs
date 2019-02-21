using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextPetbotol : MonoBehaviour
{
    private int value;
    GameObject ResultUI2_12;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_12 = GameObject.Find("ResultText2_12");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["Petbotol(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {

            uitext.text = Convert.ToString(value*0.03) + "kg";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}