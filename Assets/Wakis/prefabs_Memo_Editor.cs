using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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
[CustomEditor(typeof(prefabs_Memo))]
public class prefabs_Memo_Editor: Editor
{
    private Vector2 Scroller;
    public override void OnInspectorGUI()
    {
        var memo = target as prefabs_Memo;


        EditorGUILayout.LabelField("メモだよ、実行に影響ない");
        memo.name=(NAME)EditorGUILayout.EnumPopup("メモ作成者", memo.name);


        int n = memo.Note.Length - memo.Note.Replace('\n'.ToString(), "").Length;
        int h = 0;
        if (40 / 3 * 2 + (40 / 3) * n < 120) h = 40 + (40 / 3) * n;
        else h = 120;
        Scroller = EditorGUILayout.BeginScrollView(Scroller, GUILayout.Height(h));
        memo.Note =
            EditorGUILayout.TextArea(memo.Note, GUILayout.Height(40/3*2 + (40 / 3) * n));
        EditorGUILayout.EndScrollView();
    }
}