using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StoryPanel : MonoBehaviour
{
    public Image Panel;
    public GameObject rute;
    float time = 0.0f;
    [SerializeField, Header("消す時間"), Tooltip("未設定でもれなくワキルーム行")]
    public float p = 0;
    void Start()
    {
        Panel.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rute.gameObject.activeSelf == true)
        {
            Panel.GetComponent<Image>().enabled = true;
            time = time + Time.deltaTime;
            if (time >= p)
            {
                Panel.gameObject.SetActive(false);
                Panel.gameObject.GetComponent<Image>().enabled = false;
            }
        }
    }
}

