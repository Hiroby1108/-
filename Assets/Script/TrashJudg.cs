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
        
        if (col.gameObject.tag == "Iruka")
        {
            Debug.Log("1");
            if (IrukaTuchJudg.Trashnum <= TrashRecovery)
            {
                SceneManager.LoadScene("Result"); //ミッションクリアシーンへ移動
                Debug.Log("成功!!!");
            }else {
                SceneManager.LoadScene("result"); //ミッション失敗シーンへ移動
                Debug.Log("失敗...");
            }
            
        }
    }
}
