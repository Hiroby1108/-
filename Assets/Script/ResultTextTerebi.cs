using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextTerebi : MonoBehaviour
{
    private int value;
    GameObject ResultUI2_52;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI2_52 = GameObject.Find("ResultText2_52");
        Text uitext = GetComponent<Text>();

        value = PlayeGetItem.getTrashList()["Terebi(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            uitext.text = Convert.ToString(value * 40) + "kg";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}