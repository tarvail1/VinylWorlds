using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine; using System.Collections;

public class CameraChanger : MonoBehaviour
{
    public GameObject FPSController;
    public GameObject VRCameraRig;

    public int cameraStatus; //1 = FPS, 2 = VR

// Use this for initialization
    void Start()
    {
        FPSController.SetActive(true);
        VRCameraRig.SetActive(false);
        cameraStatus = 1;
    }

// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v") && cameraStatus == 1) //switch from FPS to VR
        {
            Debug.Log("V pressed");
            FPSController.SetActive(false);
            VRCameraRig.SetActive(true);
            cameraStatus = 2;
        }

        if (Input.GetKeyDown("b") && cameraStatus == 2) //switch from VR to FP
        {
            Debug.Log("B pressed");
            FPSController.SetActive(true);
            VRCameraRig.SetActive(false);
            cameraStatus = 1;
        }

    }
}