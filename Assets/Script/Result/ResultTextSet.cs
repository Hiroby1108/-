using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultTextSet : MonoBehaviour{
    GameObject ResultUI_1;
    GameObject ResultUI_11_2;
    //GameObject ResultUI_1_3;
    GameObject ResultUI_2;
    GameObject ResultUI_22;
    public float life = 10.0f;
    private int SceneCount=0;
    public float scene = 7.0f;
    void Start(){
        ResultUI_1 = GameObject.Find("ResultText1");
        ResultUI_11_2 = GameObject.Find("ResultText11_2");
        //ResultUI_1_3 = GameObject.Find("ResultText1_3");
        ResultUI_22 = GameObject.Find("ResultText_22");
    }

    void Update(){
        if (SceneCount == 0)
        {
            life -= Time.deltaTime;
            if (life < 0)
            {
                TextTransparence();
                SceneCount = 1;
                life = 10.0f;
                TextDisplay_1();
            }
        }
        if (SceneCount == 1){
            life -= Time.deltaTime;
            if (life < 0)
            {
                TextTransparence_1();
                SceneCount = 2;
                life = 10.0f;
                TextDisplay_2();
            }
        }
        if (SceneCount == 2){
            life -= Time.deltaTime;
            if (life < 0){
                Debug.Log("ResultFin");
                scene -= Time.deltaTime;
            }
            if (scene < 0)
            {
                SceneFade.FadeOut(0);
            }
        }
    }

    private void TextTransparence(){    //最初のリザルト画面(回収したごみの表示テキスト）の非表示
        Destroy(ResultUI_1);
    }
    private void TextTransparence_1(){    //2番目のリザルト画面(全体の回収したごみの表示テキスト）の非表示
        Destroy(ResultUI_11_2);
    }

        private void TextDisplay_1(){   //リザルト画面その2のÜI表示
        ResultUI_11_2.GetComponent<Canvas>().enabled = true;
    }


    private void TextDisplay_2(){   //リザルト画面その3のÜI表示
        ResultUI_22.GetComponent<Canvas>().enabled = true;
    }


}
