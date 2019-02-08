using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarCamera : MonoBehaviour
{

    private ItemGenerat IG;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        IG = GameObject.Find("ItemGenerator").GetComponent<ItemGenerat>();
        Player = GameObject.Find("Splasher_Mouth");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPositioon = Player.transform.position;
        thisPositioon.y = IG.Range + 100f;
        this.transform.position = thisPositioon;
    }
}
