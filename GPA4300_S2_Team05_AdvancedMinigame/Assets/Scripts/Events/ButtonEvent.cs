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

    private float t;

    private void Start()
    {
        //player = GetComponent<PlayerControll>();
        player = GetComponent<PlayerControll>();
        player.isGrounded = true;

        platformLength = Vector3.Distance(startMark.position, endMark.position);
    }

    private void Update()
    {
        if (onButton)
        {
            t += Time.deltaTime * speed;
            Platform.transform.position = Vector3.Lerp(startMark.position, endMark.position, t);
        }
        else if (!onButton)
        {
            t += Time.deltaTime * speed;
            //Platform.transform.position = Vector3.Lerp(endMark.position, startMark.position, t);
        }
    }

    private void OnCollisionEnter(Collision button)
    {
        if (button.gameObject.tag == "Player")
        {
            startTime = Time.time;
            transform.Translate(0, -ButtonDown, 0);
            onButton = true;
            t = 0;
        }
    }

    private void OnCollisionExit(Collision button)
    {
        Platform.transform.position = Vector3.Lerp(endMark.position, startMark.position, t);
        startTime = Time.time;
        onButton = false;
        t = 0;
    }
}
