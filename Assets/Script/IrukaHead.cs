using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrukaHead : MonoBehaviour
{
    public int RuteAreaUnderNum;
    public float irukaPos = 2;
    /*イルカのスピードを変更したら↓を参考にirukaPosを変更すること
    0.05→デフォ「1」　0.25→2　0.45→3 0.65→4 */
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RuteAreaSet.judg == true) {
            this.transform.position = new Vector3(((RuteAreaSet.getruteX / 2) +RuteAreaSet.getposX +28) * irukaPos, RuteAreaSet.getposY+ RuteAreaUnderNum+5, RuteAreaSet.getposZ);
            //0.05→デフォ　0.25→*2　0.45→*3 0.65→*4
            RuteAreaSet.judg = false;
        }
    }
}
