using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaCloudy : MonoBehaviour
{
    public GameObject Sea;
    byte g = 142;
    byte b = 0;
    byte alfa = 180;
    void Start()
    {
    }
    void Update()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trash")
        {
            if (alfa > 0)
            {
                if (b < 250)
                {
                    g -= 5;
                    b += 5;//画面に少しばかり青みを持たせる
                    alfa -= 5;//画面の透明度を変化
                    Debug.Log(b);
                    Sea.GetComponent<Renderer>().material.color = new Color32(0, g, b, alfa);
                }
            }

        }

    }
}