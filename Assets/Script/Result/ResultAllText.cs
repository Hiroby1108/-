using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultAllText : MonoBehaviour
{
    private int num;
    public float TrashAllTotal = 0;
    GameObject ResultUI1_3;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("SCORE");   //スコア初期化
        TrashAllTotal = PlayerPrefs.GetFloat("SCORE", 0);   //("キー（保存場所）",データがない場合のデフォ値）

        ResultUI1_3 = GameObject.Find("ResultText1_3");
        Text uitext = GetComponent<Text>();
        if (TrashAllTotal == 0)
        {
            TrashAllTotal += (ResultTextMyTotal.mytotal / 1000);
            uitext.text = /*(numf)*/ + TrashAllTotal + "";
            Debug.Log("a" + TrashAllTotal);
            OnDestroy();
            Debug.Log("PlayerPrefs保存完了");
        }
        else
        {
            TrashAllTotal += (ResultTextMyTotal.mytotal / 1000);
            uitext.text = TrashAllTotal + "";
            Debug.Log("b" + TrashAllTotal);
            OnDestroy();
            Debug.Log("PlayerPrefs保存完了");
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
        PlayerPrefs.SetFloat("SCORE", TrashAllTotal);   //TrashAllTotalの値をSCORE(キー)にセット
        PlayerPrefs.Save(); //全ての変更内容を保存
    }
}