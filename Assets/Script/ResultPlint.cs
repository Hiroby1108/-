using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultPlint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(PlayeGetItem.getLivingList());

        Debug.Log(PlayeGetItem.getTrashList());
        //Debug.Log(PlayeGetItem.getTrashList()/*["tabako"]*/);
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getTrashList())
        {
            Debug.Log(DictKvp);
        }
        foreach (KeyValuePair<string, int> DictKvp in PlayeGetItem.getLivingList())
        {
            Debug.Log(DictKvp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
