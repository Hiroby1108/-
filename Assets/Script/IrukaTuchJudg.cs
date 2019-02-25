using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrukaTuchJudg : MonoBehaviour
{
    public static int Trashnum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Trash"){
            Trashnum++;
            Destroy(col.gameObject);
        }
    }
}
