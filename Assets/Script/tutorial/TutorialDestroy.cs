using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutorialDestroy : MonoBehaviour
{

    public Image Panel;
    public Text myText;
    [SerializeField, Header("消す時間"), Tooltip("未設定でもれなくワキルーム行")]
    public float p = 0;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "※周りの円はエリアを可視化したものです";
        Destroy(myText, p);
        Destroy(Panel, p);
    }
}