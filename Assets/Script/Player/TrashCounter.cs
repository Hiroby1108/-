using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrashCounter : MonoBehaviour
{
    Text myText;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Score").GetComponentInChildren<Text>();
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
            myText.text = "ゴミの回収量:"+i;
        }

        }
}
