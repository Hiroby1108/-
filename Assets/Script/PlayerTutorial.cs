using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTutorial : MonoBehaviour
{
    Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
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
        }
    }
}
