using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextSet : MonoBehaviour{
    GameObject ResultUI_1;
    /*GameObject ResultUI_1_1;  //修正用
    GameObject ResultUI_1_2;
    GameObject ResultUI_1_3;*/
    GameObject ResultUI_2;
    GameObject ResultUI_22;
    public float life = 3.0f;
    private int SceneCount;
    void Start(){
        ResultUI_1 = GameObject.Find("ResultText1");
        /*ResultUI_1_1 = GameObject.Find("ResultText1_1");  //修正用
        ResultUI_1_2 = GameObject.Find("ResultText1_2");
        ResultUI_1_3 = GameObject.Find("ResultText1_3");*/
        //ResultUI_2 = GameObject.Find("ResultText2");
        ResultUI_22 = GameObject.Find("ResultText22");
        ResultUI_2 = GameObject.Find("test");
    }

    void Update(){
        life -= Time.deltaTime;
        if (life < 0){
            TextTransparence_1();
            SceneCount = 1;
            life = 3.0f;
            TextDisplay_2();
        }
        if (SceneCount == 1){
            life -= Time.deltaTime;
            if (life < 0){
                Debug.Log("ResultFin");
            }
        }
    }

    private void TextTransparence_1(){    //最初のリザルト画面(回収したごみの表示テキスト）の非表示
        Destroy(ResultUI_1);
        //ResultUI_1.GetComponent<Text>().enabled = false;  //修正用（テキストを個別非表示させたい場合）
        //ResultUI_1_1.GetComponent<Text>().enabled = false;
        //ResultUI_1_2.GetComponent<Text>().enabled = false;
        //ResultUI_1_3.GetComponent<Text>().enabled = false;
    }

    private void TextDisplay_2(){   //リザルト画面その2のÜI表示
        ResultUI_2.GetComponent<Canvas>().enabled = true;
    }
}
