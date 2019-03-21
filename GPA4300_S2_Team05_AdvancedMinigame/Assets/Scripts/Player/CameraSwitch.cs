using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject LeilaCam;
    public GameObject DanCam;

    [HideInInspector] public bool camSwitch = false;

    void Update()
    {
        if (Input.GetButtonDown("CameraSwitch"))
        {
            camSwitch = !camSwitch;
            DanCam.SetActive(camSwitch);
            LeilaCam.SetActive(!camSwitch);
        }
    }
}
