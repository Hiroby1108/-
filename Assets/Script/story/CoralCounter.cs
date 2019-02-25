using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoralCounter : MonoBehaviour
{
    public Image Panel;
    public Image CoralPanel;
    Text myText;
    private int i = 0;
    void Start()
    {
        myText = GameObject.Find("CoralCounter").GetComponentInChildren<Text>();
        CoralPanel.GetComponent<Image>().enabled = false;
        myText.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel.gameObject.activeSelf == false)
        {
            CoralPanel.GetComponent<Image>().enabled = true;
            myText.GetComponent<Text>().enabled = true;

        }
    }
    void OnCollisionEnter(Collision col)
    {
            if (col.gameObject.tag == "Trash")
        {

            i++;
            myText.text = "ゴミの落下数:" + i;
        }

    }
}
