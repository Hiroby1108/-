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
    }
    private STEP step;              // 今のSTEP.
    private STEP next_step;      // 次のSTEP.
    private float step_timer;     // 経過時間を入れる.
    private PlayerController player;    // playerと連携.


    [SerializeField, Header("次のシーン名"),Tooltip("未設定でもれなくワキルーム行")]
    private string NextSceneName;

    [SerializeField, Header("制限時間")]
    private float limitTime;
    
    
    private ItemGenerat IG;
    private bool OneLoad;
    private int n_Trash;
    private int n_Living;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(NextSceneName);
        IG = GameObject.Find("ItemGenerator").GetComponent<ItemGenerat>();
        n_Trash = IG.NumOfTrash;
        n_Living = IG.NumOfLiving;
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        next_step = STEP.SET;    // 最初はSETから.
        if (NextSceneName=="")
        {
            NextSceneName = SceneManager.GetActiveScene().name;
            Debug.Log(NextSceneName);
        }
        OneLoad = true;
    }

    // Update is called once per frame


    void Update()
    {
        step_timer += Time.deltaTime;    // 経過時間を取得.

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
                if (limitTime < step_timer) next_step = STEP.FINISH;
                break;
            case STEP.FINISH:
                SceneManager.LoadScene(NextSceneName);
                break;
        }

    }


}
