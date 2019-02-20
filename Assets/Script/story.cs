using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class story : MonoBehaviour
{

    Text Story;
         
   public GameObject rute;

    void Start()
    {
        Story = GameObject.Find("Story").GetComponentInChildren<Text>();

        Story.GetComponent<Text>().enabled = false;
        rute.gameObject.SetActive(false);
    }

    void Update()
    {
        Invoke("call", 4.0f);
    }
    void call()
    {
        Story.GetComponent<Text>().enabled = true;
        rute.gameObject.SetActive(true);

             }
}
