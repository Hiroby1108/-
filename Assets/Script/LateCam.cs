using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateCam : MonoBehaviour
{
    Transform cameraTrans;
    Transform player;
    [SerializeField]
        Transform playerTrans;
    [SerializeField]
    Vector3 cameraVec;
        void Awake()
        {
            cameraTrans = transform;
        }
        void LateUpdate()
        {
        {
            cameraTrans.position = Vector3.Lerp(cameraTrans.position, playerTrans.position + cameraVec, 1.0f * Time.deltaTime);
        }
    }
    }