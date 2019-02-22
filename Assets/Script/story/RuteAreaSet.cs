using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuteAreaSet : MonoBehaviour
{
    public int ruteScaleX=130, ruteScaleY, ruteScaleZ;
    public static int getruteX,getruteY,getruteZ;
    public static float getposX,getposY,getposZ;
    public static bool judg;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localScale = new Vector3(ruteScaleX, ruteScaleY, ruteScaleZ);
        getruteX = ruteScaleX; getruteY = ruteScaleY; getruteZ = ruteScaleZ;
        getposX = this.transform.position.x;
        getposY = this.transform.position.y;
        getposZ = this.transform.position.z;
        judg = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
