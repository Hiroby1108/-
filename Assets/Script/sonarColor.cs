using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonarColor : MonoBehaviour
{
    private ItemGenerat IG;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        IG = GameObject.Find("ItemGenerator").GetComponent<ItemGenerat>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float thisHeight_def = (255f / 2f) + 
            (this.transform.parent.transform.position.y-Player.transform.position.y)*(255f/2f)/IG.Range;

        float thisHeight = Mathf.InverseLerp(0f , 255f , thisHeight_def);
        this.GetComponent<Renderer>().material.color = new Color(thisHeight, thisHeight, thisHeight,255);
        
    }
}
