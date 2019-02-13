using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class story : MonoBehaviour
{
         Text Story;
         Text Score;
   public GameObject rute;
    void Start()
    {
        Story = GameObject.Find("Story").GetComponentInChildren<Text>();
        Score = GameObject.Find("Score").GetComponentInChildren<Text>();
        Story.GetComponent<Text>().enabled = false;
    }

    void Update()
    {
        Invoke("call", 2.0f);
    }
    void call()
    {
        
        Story.GetComponent<Text>().enabled = true;
        gameObject.SetActive(true);
    }
}
