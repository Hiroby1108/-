using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMouseRot : MonoBehaviour, IController
{

    public float sensitivity = 0.1f;
    float x,x_;
    float y;
    float m;
    // Start is called before the first frame update
    void Start()
    {
        x = y = m = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse Y")*10f ;
        Debug.Log(x);
        y += Input.GetAxis("Mouse X") * sensitivity;

        

        if (x < -90f) x = -90f;
        else if (x > 90f) x = 90f;
        if (y < -90f) y = -90f;
        else if (y > 90f) y = 90f;
        
        m+=Input.GetAxis("Mouse ScrollWheel");
        if (m <= 0f) m = 0f;
        else if (m > 90f) m = 90f;

        if (Input.GetKeyDown(KeyCode.R)){
            x = 0f;
            y = 0f;
            m = 0f;
        }
    }
    public float rotX()
    {

        return x;
    }
    public float rotY()
    {
        return y;
    }
    public float openMouth()
    {
        return m;
    }
    

}
