using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaCloudy : MonoBehaviour
{
    public GameObject Sea;

    byte c = 0;
    byte d = 180;
    void Start()
    {
    }
    void Update()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Trash")
        {
            if (d > 0)
            {
                if (c < 250)
                {
                    c += 14;
                    d -= 10;
                    Debug.Log(c);
                    Sea.GetComponent<Renderer>().material.color = new Color32(0, 0, c, d);
                }
            }

        }

    }
}