using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNIUNITY_EDITOR

#endif

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
    private PlayerController player;	// playerと連携.

    [SerializeField, Header("制限時間")]
    private float limitTime;
    
    private ItemGenerat IG;
    private bool OneLoad;
    private int n_Trash;
    private int n_Living;


    // Start is called before the first frame update
    void Start()
    {
        IG = GameObject.Find("ItemGenerator").GetComponent<ItemGenerat>();
        n_Trash = IG.NumOfTrash;
        n_Living = IG.NumOfLiving;
        //player = GameObject.Find("ItemGenerator").GetComponent<PlayerController>();

        OneLoad = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
