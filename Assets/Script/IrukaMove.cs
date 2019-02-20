using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrukaMove : MonoBehaviour
{
    public float irukaSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
        if (IrukaTime.count == true)
        {
            Vector3 pos = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(pos.x - irukaSpeed, pos.y, pos.z);
        }
    }
}
