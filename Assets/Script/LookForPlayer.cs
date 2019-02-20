using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForPlayer : MonoBehaviour
{
    private GameObject PlayerCam;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCam == null) Start();
        this.transform.LookAt(PlayerCam.transform);
        Vector3 v = this.transform.eulerAngles;
        this.transform.eulerAngles = new Vector3(-v.x, v.y - 180f, v.z);
    }
}
