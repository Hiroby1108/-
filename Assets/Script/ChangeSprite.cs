using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public Sprite up;
    public Sprite right;
    public Sprite left;
    public Sprite down;

    public void changeUtoR(){
        this.gameObject.GetComponent<Image>().sprite = right;
    }

    public void changeRtoL()
    {
        this.gameObject.GetComponent<Image>().sprite = left;
    }

    public void changeLtoD()
    {
        this.gameObject.GetComponent<Image>().sprite = down;
    }

    public void spriteOff()
    {
        this.gameObject.GetComponent<Image>().enabled = false;
    }
}
