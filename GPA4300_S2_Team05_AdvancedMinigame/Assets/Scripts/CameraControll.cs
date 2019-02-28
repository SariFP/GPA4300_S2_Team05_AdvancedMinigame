using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public GameObject LeilaCam;
    public GameObject DanCam;

    [HideInInspector] public bool camSwitch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
