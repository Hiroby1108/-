using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNIUNITY_EDITOR

#endif

public class GameRule : MonoBehaviour
{

    private ItemGenerat IG;
    private bool OneLoad;
    

    // Start is called before the first frame update
    void Start()
    {
        IG = GameObject.Find("ItemGenerator").GetComponent<ItemGenerat>();
        OneLoad = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
