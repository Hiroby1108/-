using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TrackerGetter : MonoBehaviour
{
    public GameObject[] targetObjs;
    public ETrackedDeviceClass targetClass = ETrackedDeviceClass.GenericTracker;
    public KeyCode resetDeviceIds = KeyCode.Tab;

    CVRSystem _vrSystem;
    List<int> _validDeviceIds = new List<int>();

    private Vector3[] TrackRot;
    public Vector3 getTrackRot()
    {
        return TrackRot[0];
    }

    void Start()
    {
        var error = EVRInitError.None;
        _vrSystem = OpenVR.Init(ref error, EVRApplicationType.VRApplication_Other);

        if (error != EVRInitError.None) { Debug.LogWarning("Init error: " + error); }

        else
        {
            Debug.Log("init done");
            foreach (var item in TrackRot) { item.SetActive(false); }
            SetDeviceIds();
        }
    }

    void SetDeviceIds()
    {
        _validDeviceIds.Clear();
        for (uint i = 0; i < OpenVR.k_unMaxTrackedDeviceCount; i++)
        {
            var deviceClass = _vrSystem.GetTrackedDeviceClass(i);
            if (deviceClass != ETrackedDeviceClass.Invalid && deviceClass == targetClass)
            {
                Debug.Log("OpenVR device at " + i + ": " + deviceClass);
                _validDeviceIds.Add((int)i);
                TrackRot[_validDeviceIds.Count - 1].SetActive(true);
            }
        }
    }

    void UpdateTrackedObj()
    {
        TrackedDevicePose_t[] allPoses = new TrackedDevicePose_t[OpenVR.k_unMaxTrackedDeviceCount];

        _vrSystem.GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin.TrackingUniverseStanding, 0, allPoses);

        for (int i = 0; i < _validDeviceIds.Count; i++)
        {
            if (i < TrackRot.Length)
            {
                var pose = allPoses[_validDeviceIds[i]];
                var absTracking = pose.mDeviceToAbsoluteTracking;
                var mat = new SteamVR_Utils.RigidTransform(absTracking);
                // targetObjs[i].transform.SetPositionAndRotation(mat.pos, mat.rot);
                //targetObjs[i].transform.rotation= new Vector3(1, 1, 1);

                //targetObjs[i].transform.rotation = mat.rot;
                TrackRot[i] = mat.rot;
            }

        }
    }

    void Update()
    {
        UpdateTrackedObj();

        if (Input.GetKeyDown(resetDeviceIds))
        {
            SetDeviceIds();
        }
    }
}