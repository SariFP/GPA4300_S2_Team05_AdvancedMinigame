using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    public GameObject Platform;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public float ButtonDown;

    [Header("LerpTry")]
    public Transform startMark;
    public Transform endMark;

    public float speed = 1.0f;
    public float t;

    public bool onButton;
    public bool onPlatform;

    private void Start()
    {
        PlayerLeila.GetComponent<PlayerControll>().isGrounded = true;
        PlayerDan.GetComponent<PlayerControll>().isGrounded = true;
    }

    private void Update()
    {
        if (onButton)
        {
            t += Time.deltaTime * speed;

        }
        else
        {
            t -= Time.deltaTime * speed;
            //Platform.transform.position = Vector3.Lerp(startMark.position, endMark.position, t);
        }
        t = Mathf.Clamp01(t);

        Platform.transform.position = Vector3.Lerp(startMark.position, endMark.position, t);

    }

    private void OnCollisionEnter(Collision button)
    {
        if (button.gameObject.tag == "Player")
        {
            transform.Translate(0, -ButtonDown, 0);
            onButton = true;
            //t = 0;
        }
    }

    private void OnCollisionExit(Collision button)
    {
        if (button.gameObject.tag == "Player")
            onButton = false;
    }
}
