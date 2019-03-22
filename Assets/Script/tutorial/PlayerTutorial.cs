using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerTutorial : MonoBehaviour
{
    public GameObject myText2;
    Text myText;
    private int i = 0;
    private int x=0;

   [SerializeField, Header("次のシーン名"), Tooltip("未設定でもれなくワキルーム行")]
    public string NextSceneName;
    [SerializeField, Header("次のシーン名"), Tooltip("未設定でもれなくワキルーム行")]
    public string NextSceneNameTurtle;
    [SerializeField, Header("次のシーン名"), Tooltip("未設定でもれなくワキルーム行")]
    public string NextSceneNameCoral;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Text").GetComponentInChildren<Text>();
        //NextSceneName = SceneManager.GetActiveScene().name;
        //  NextSceneName
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
        }
        if (i == 3)
        {
            x = Random.Range(1, 4);

            if(x == 1){
            myText.GetComponent<Text>().enabled = true;
                myText2.SetActive(false);
                myText.text = "チュートリアルは終了です";
            Invoke("SceneChange", 2.0f);
            }
            if (x == 2)
            {
                myText.GetComponent<Text>().enabled = true;
                myText2.SetActive(false);
                myText.text = "チュートリアルは終了です";
                Invoke("SceneChangeTurtle", 2.0f);
            }
            if (x == 3)
            {
                myText.GetComponent<Text>().enabled = true;
                myText2.SetActive(false);
                myText.text = "チュートリアルは終了です";
                Invoke("SceneChangeCoral", 2.0f);
            }
        }
    }
    void SceneChange()
    {
        
        SceneFade.FadeOut(3);
        Debug.Log(NextSceneName);
    }
    void SceneChangeTurtle()
    {
        SceneFade.FadeOut(4);
        Debug.Log(NextSceneNameTurtle);
    }
    void SceneChangeCoral()
    {
        SceneFade.FadeOut(5);
        Debug.Log(NextSceneNameCoral);
    }

}
