using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrukaText : MonoBehaviour
{
    Text myText;
    public Image IrukaPanel;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("IrukaText").GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.a == true)
        {
            Destroy(myText);
            IrukaPanel.GetComponent<Image>().enabled = false;
        }
    }
}
