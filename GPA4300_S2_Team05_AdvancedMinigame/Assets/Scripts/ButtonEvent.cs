using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    [HideInInspector]public PlayerControll player;
    public GameObject Platform;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public float ButtonDown;
    public float PlatformDistance;

    public bool onPlatform;
    public bool usedOnce;

    private Vector3 originPointButton;
    private Vector3 originPointPlatform;
    //public Transform endMark;

    private void Start()
    {
        player = GetComponent<PlayerControll>();
        player.isGrounded = true;

        onPlatform = false;
    }

    private void OnCollisionEnter(Collision button)
    {
        if (button.gameObject.tag == "Player")
        {
            onPlatform = true;
            transform.Translate(0, -ButtonDown, 0);
            Platform.transform.Translate(0, 0, - PlatformDistance);
        }
    }

    private void OnCollisionExit(Collision button)
    {
        if (button.gameObject.tag != "Player")
        {
            onPlatform = false;
            transform.Translate(0, ButtonDown, 0);
            Platform.transform.Translate(0, 0, PlatformDistance);
        }
    }

    //private void Update()
    //{
    //    if (Platform.transform.position == PlayerLeila.transform.position)
    //    {
            
    //    }
    //    else if (Platform.transform.position == PlayerDan.transform.position)
    //    {

    //    }
    //}
}
