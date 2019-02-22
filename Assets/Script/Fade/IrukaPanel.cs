using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrukaPanel : MonoBehaviour
{
    public Image Panel;
    public GameObject rute;
    // Start is called before the first frame update
    void Start()
    {
        Panel.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
         if (rute.gameObject.activeSelf == true)
        {
            Panel.GetComponent<Image>().enabled = true;

        }
    }
}
