using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRule : MonoBehaviour
{
    public enum STEP
    {            // 状況を管理するSTEP作成.
        NONE = -1,
        SET,
        PLAY,
        FINISH,
        GAMEOVER,
    }
    private STEP step;              // 今のSTEP.
    private STEP next_step;      // 次のSTEP.
    private float step_timer;     // 経過時間を入れる.
    private PlayerController player;    // playerと連携.


    [SerializeField, Header("次のシーン名"),Tooltip("未設定でもれなくワキルーム行")]
    private string NextSceneName;

    [SerializeField, Header("制限時間")]
    private float limitTime;

    [SerializeField, Header("残してよい量:片方は必ず0"),Tooltip("Dif Leftは差(個)(何個残せる)")]
    private int difLeft=0;
    [SerializeField, Range(0, 100),Tooltip("Rat Leftは割合(%)(何%残せる-切り捨て)")]
    private float ratLeft=0;

    private int leftOver;

    private ItemGenerat IG;
    private bool OneLoad;
    private int Max_Trash;
    private int Max_Living;
    private int Now_Trash;
    private int Now_Living;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("S"+getTags_Obj("Trash"));
        IG = GameObject.Find("ItemGenerator").GetComponent<ItemGenerat>();
        Max_Trash = IG.NumOfTrash + getTags_Obj("Trash");
        Max_Living = IG.NumOfLiving + getTags_Obj("Living");
        Debug.Log("N" + getTags_Obj("Trash"));

        player = GameObject.Find("Player").GetComponent<PlayerController>();
        next_step = STEP.SET;    // 最初はSETから.

        if (difLeft != 0 && ratLeft != 0) leftOver = 0;
        else if (difLeft > 0 && ratLeft == 0) leftOver = difLeft;
        else if (difLeft == 0 && ratLeft > 0) leftOver = (int)(ratLeft/100f* Max_Trash);
        else leftOver = 0;
        if (leftOver > Max_Trash) leftOver = Max_Trash - 1;

        if (NextSceneName == "")
        {
            NextSceneName = SceneManager.GetActiveScene().name;
            Debug.Log(NextSceneName);
        }
        OneLoad = true;
        Debug.Log("E" + getTags_Obj("Trash"));
    }

    // Update is called once per frame


    void Update()
    {
        step_timer += Time.deltaTime;    // 経過時間を取得.
        Now_Trash = getTags_Obj("Trash");
        Now_Living = getTags_Obj("Living");

        // （１）ステップ変化時のみ.
        if (next_step != STEP.NONE)
        {
            step = next_step;       // 現状に反映.
            next_step = STEP.NONE;  // 変化待ち.
            step_timer = 0.0f;      // 経過時間リセット.

            switch (step)
            {
                case STEP.SET:
                    next_step = STEP.PLAY;  // 次はPLAYステップに.
                    break;
            }
        }

        // （２）繰り返し実行.
        switch (step)
        {
            case STEP.PLAY://Player操作
                if (limitTime < step_timer) next_step = STEP.GAMEOVER;
                if (Now_Trash <= leftOver) next_step = STEP.FINISH;
                break;
            case STEP.FINISH:
                SceneManager.LoadScene(NextSceneName);
                break;
            case STEP.GAMEOVER:
                SceneManager.LoadScene(NextSceneName);
                break;
        }
    }

    private int getTags_Obj(string objTag)
    {
        int num = 0;
        foreach (GameObject obj in UnityEngine.Object.FindObjectsOfType(typeof(GameObject)))
        {
            if (obj.activeInHierarchy && obj.tag == objTag)
            {
                num++;
            }
        }
        return num;
    }
}
