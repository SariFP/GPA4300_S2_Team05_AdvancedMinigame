using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{
    public CinemachineFreeLook SplitCam;
    public CinemachineFreeLook OneCam;

    void Update()
    {
        
        SplitCam.m_XAxis.Value = 0.2f;
        SplitCam.m_YAxis.Value = 0.5f;
    }
}
