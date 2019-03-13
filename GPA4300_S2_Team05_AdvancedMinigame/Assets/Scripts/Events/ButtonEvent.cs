using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    //public List<GameObject> button = new List<GameObject>();
    public GameObject Button1;
    public GameObject Button2;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public float ButtonDown;

    [Header("LerpTry")]
    public Transform startMark;
    public Transform endMark;

    public float speed = 1.0f;
    public float t;

    public bool onButton;

    private void Start()
    {
        PlayerLeila.GetComponent<PlayerControll>().isGrounded = true;
        PlayerDan.GetComponent<PlayerControll>().isGrounded = true;
    }

    private void Update()
    {
        if (PlayerLeila.gameObject.tag == "Button" || PlayerDan.gameObject.tag == "Button")
        {
            onButton = true;
        }
        else
        {
            onButton = false;
        }

        if (onButton)
        {
            t += Time.deltaTime * speed;
        }
        else
        {
            t -= Time.deltaTime * speed;
        }
        t = Mathf.Clamp01(t);

        transform.position = Vector3.Lerp(startMark.transform.position, endMark.transform.position, t);

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (Button1.gameObject.tag == "Player" || Button2.gameObject.tag == "Player")
    //    {
    //        //transform.Translate(0, -ButtonDown, 0);
    //        onButton = true;
    //        //t = 0;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (Button1.gameObject == PlayerLeila.gameObject || Button2.gameObject == PlayerDan.gameObject)
    //        onButton = false;
    //}
}
