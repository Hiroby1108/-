using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabs_Memo : MonoBehaviour
{
    /*書き換え厳禁*/
    public enum NAME
    {
        NONE,
        Miyashita,
        Ohshima,
        Ohsawa,
        Inomata,
        Ikoda,
        Chida,
        Waki,
    }
    [SerializeField, Tooltip("自分の名前を選んで")]
    private NAME nameTag;
    [SerializeField,Header("メモ,自分のタグ付けて"),TextArea(3, 5),Tooltip("")]
    private string note;
}

