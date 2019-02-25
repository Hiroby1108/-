using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoralMission : MonoBehaviour
{
    [SerializeField, Header("次のシーン名"), Tooltip("未設定でもれなくワキルーム行")]
    public string NextSceneName;
    private int i=0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trash")
        {
            i++;
            if (i == 30)
            {
                Invoke("SceneChange", 2.0f);
            }
        }
    }
    void SceneChange()
    {
        SceneFade.FadeOut(5);
        Debug.Log(NextSceneName);
    }
}
