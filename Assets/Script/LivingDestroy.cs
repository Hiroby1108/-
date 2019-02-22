using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Living")
        {
            Debug.Log("生き物消えた");
            Destroy(col.gameObject);
        }
    }
}
