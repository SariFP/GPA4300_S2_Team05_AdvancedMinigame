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
        OneCam.m_XAxis.Value = 0.1f;
        OneCam.m_YAxis.Value = 0.5f;

        SplitCam.m_XAxis.Value = 0.1f;
        SplitCam.m_YAxis.Value = 0.5f;
    }
}
