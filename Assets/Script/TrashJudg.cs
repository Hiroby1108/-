using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashJudg : MonoBehaviour
{
    [SerializeField, Header("イルカがゴミを食べてもいい数")]
    public int TrashRecovery;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "MissionLiving")
        {
            IrukaTime.count = false;
            KameTime.count = false;
            RuteAreaSet.judg = false;
            if (MissionTuchJudg.Trashnum <= TrashRecovery)
            {
                //なんかの値に変化させてシーンの読み込みを変えさせる（時間制限で）
                SceneFade.FadeOut(5); //ミッションクリアシーンへ移動
                Debug.Log("成功!!!");
            }else {
                SceneFade.FadeOut(5); //ミッション失敗シーンへ移動
                Debug.Log("失敗...");
            }
            
        }
    }
}
