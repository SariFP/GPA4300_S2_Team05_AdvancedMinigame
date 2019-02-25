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

    [Header("LerpTry")]
    public Transform startMark;
    public Transform endMark;

    public float speed = 1.0f;

    private float startTime;
    private float platformLength;

    private bool onButton;

    private void Start()
    {
        //player = GetComponent<PlayerControll>();
        player.isGrounded = true;

        startTime = Time.time;
        platformLength = Vector3.Distance(startMark.position, endMark.position);
    }

    private void Update()
    {
        if (onButton)
        {
            //Platform.transform.Translate(0, 0, -PlatformDistance);
                float distCovered = (Time.time - startTime) * speed;
                float fracPlatform = distCovered / platformLength;

                Platform.transform.position = Vector3.Lerp(startMark.position, endMark.position, fracPlatform);
        }
    }

    private void OnCollisionEnter(Collision button)
    {
        if (button.gameObject.tag == "Player")
        {
            transform.Translate(0, -ButtonDown, 0);
            //Platform.transform.Translate(0, 0, - PlatformDistance);
            onButton = true;
        }
    }

    private void OnCollisionExit(Collision button)
    {
        if (button.gameObject.tag != "Player")
        {
            transform.Translate(0, ButtonDown, 0);
            //Platform.transform.Translate(0, 0, PlatformDistance);
            onButton = false;
        }
    }
}
