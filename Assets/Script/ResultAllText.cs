using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultAllText : MonoBehaviour
{
    private int num;
    private float numf=0f;
    public float TrashAllTotal = 0;
    GameObject ResultUI1_3;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("SCORE");   //スコア初期化
        TrashAllTotal = PlayerPrefs.GetFloat("SCORE", 0);

        ResultUI1_3 = GameObject.Find("ResultText1_3");
        Text uitext = GetComponent<Text>();
        if (TrashAllTotal == 0)
        {
            //num = (int)(ResultTextMyTotal.mytotal * 10);
            //numf += ((float)num) / 1000f;
            //Debug.Log("a" + num);
            //Debug.Log("a" + numf);
            TrashAllTotal += (ResultTextMyTotal.mytotal / 1000);
            uitext.text = /*(numf)*/ + TrashAllTotal + "/311,000,000t";
            //Debug.Log("a" + TrashAllTotal);
            //TrashAllTotal += (ResultTextMyTotal.mytotal / 1000);
            //Debug.Log("a2_" + TrashAllTotal);
        }
        else
        {
            TrashAllTotal += (ResultTextMyTotal.mytotal / 1000);
            uitext.text = TrashAllTotal + "/311,000,000t";
            Debug.Log("b" + TrashAllTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
// 削除時の処理
void OnDestroy()
    {
        // スコアを保存
        PlayerPrefs.SetFloat("SCORE", TrashAllTotal);
        PlayerPrefs.Save();
    }
}