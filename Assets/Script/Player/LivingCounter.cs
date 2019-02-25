using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivingCounter : MonoBehaviour
{
    Text myText;

    public int Livingnum = 10;
    private int num,t;
    [SerializeField, Header("プレイヤースピードと同じ値を設定してね")]
    public float speed;
    public static int GetLivingnum;
    [SerializeField, Header("stoptime")]
    public float life=5.0f;
    [SerializeField, Header("2回目以降のstoptime")]
    public float nextlife = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
    myText = GameObject.Find("LivingText").GetComponentInChildren<Text>();
        num = Livingnum;
    }

// Update is called once per frame
void Update()
{
        if (Livingnum <= 0)
        {
            PlayerController.getSpeed = 0f;
            life -= Time.deltaTime;
            t = Mathf.FloorToInt(life);
            myText.text = "排出完了まで残り"+t+"秒";
            if (life < 1)
            {
                PlayerController.getSpeed =speed;
                life = 5f;
                Livingnum = num;
                GetLivingnum = num;
                myText.text = "生き物排出まであと:" + Livingnum + "匹";
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Living")
        {

            Livingnum--;
            GetLivingnum = Livingnum;
            myText.text = "生き物排出まであと:" + Livingnum + "匹";
        }
    }
}