using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadePanel : MonoBehaviour
{
    public Image Panel;

    float time = 0.0f;
    [SerializeField, Header("消す時間"), Tooltip("未設定でもれなくワキルーム行")]
    public float p = 0;
    void Start()
    {

    }

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= p)
        {
            Panel.gameObject.GetComponent<Image>().enabled = false;
        }
    }
}
