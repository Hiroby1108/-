using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerTutorial : MonoBehaviour
{
    Text myText;
    int i = 0;
    [SerializeField, Header("次のシーン名"), Tooltip("未設定でもれなくワキルーム行")]
    public string NextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Text").GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trash")
        {
            Debug.Log("unko");
            i++;
        }
        if (i == 3)
        {
            myText.GetComponent<Text>().enabled = true;
            myText.text = "チュートリアルは終了です";
            Invoke("SceneChange", 2.0f);
        }
    }
    void SceneChange()
    {
        SceneManager.LoadScene(NextSceneName);
        Debug.Log(NextSceneName);
    }
}
