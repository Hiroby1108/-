using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextMyTotal : MonoBehaviour
{
    private int valueP, valueT,valueG, valueB, valueTv, valueTa,num;
    private float numf;
    GameObject ResultUI1_1;
    public static float mytotal=0f,Allmytotal=0f;
    // Start is called before the first frame update
    void Start()
    {
        ResultUI1_1 = GameObject.Find("ResultText1_1");
        Text uitext = GetComponent<Text>();

        valueP = PlayeGetItem.getTrashList()["Petbotol(Clone)"];
        valueT = PlayeGetItem.getTrashList()["tabako(Clone)"];
        valueG = PlayeGetItem.getTrashList()["Gyomou(Clone)"];
        valueB = PlayeGetItem.getTrashList()["Biniru(Clone)"];
        valueTv = PlayeGetItem.getTrashList()["Terebi(Clone)"];
        valueTa = PlayeGetItem.getTrashList()["Taiya(Clone)"];
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            mytotal = float.Parse(Convert.ToString((valueT * 0.000015f) + (valueP * 0.03f)+ (valueG * 5) + (valueB * 0.000015f) +
                                                   (valueTv * 40) + (valueTa * 18)));
            num = (int)(mytotal * 100);
            numf = (float)num / 100f;
            Debug.Log(num);
            Debug.Log(numf);
            uitext.text = numf.ToString();
            Debug.Log(mytotal);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}