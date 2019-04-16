using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUP : MonoBehaviour
{
    [SerializeField, Header("プレイヤースピード変化値")]
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            PlayerController.getSpeed =speed;
        }
    }
}
