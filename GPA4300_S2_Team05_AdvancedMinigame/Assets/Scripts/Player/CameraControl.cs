using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{
    public PauseMenu pause;

    public CinemachineFreeLook SplitCam;
    public CinemachineFreeLook OneCam;

    void Update()
    {
        OneCam.m_XAxis.Value = 0.0f;
        OneCam.m_YAxis.Value = 0.5f;

        SplitCam.m_XAxis.Value = 0.0f;
        SplitCam.m_YAxis.Value = 0.5f;

        if (pause.isPaused)
        {
            OneCam.enabled = false;

            SplitCam.enabled = false;
        }
        else
        {
            OneCam.enabled = true;

            SplitCam.enabled = true;
        }
    }
}
