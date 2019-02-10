using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    Text myText;
   public GameObject cam;
    int a=0;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 r = cam.gameObject.transform.eulerAngles;
        Debug.Log(r);
        if (r.x > 180f)
            r.x = r.x-360f;
        if (r.x>-0.1f)
        {
            Debug.Log("unko");
            call();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myText.text = "←を入力してください";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myText.text = "↓を入力してください";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myText.text = "↑を入力してください";
        }
    }
    void call()
    {
            myText.text = "→を入力してください";
        a = 2;

    }
}