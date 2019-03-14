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

        onButton = false;
    }

    private void Update()
    {
        if (PlayerLeila.gameObject == Button1.GetComponent<BoxCollider>() || PlayerDan.gameObject == Button1.gameObject)
        {
            onButton = true;
            Debug.Log("onButton");
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
    //    if (Button1.gameObject.tag == "Player")
    //    {
    //        //transform.Translate(0, -ButtonDown, 0);
    //        onButton = true;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Button")
    //    {
    //        if (collision.gameObject == PlayerLeila.gameObject || collision.gameObject == PlayerDan)
    //        {
    //            onButton = false;
    //        }
    //    }
    //}
}
