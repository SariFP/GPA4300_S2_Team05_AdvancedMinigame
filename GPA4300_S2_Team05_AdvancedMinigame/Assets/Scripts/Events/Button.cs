using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public float ButtonDown;
    public bool onButton;

    private void Start()
    {
        onButton = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.Translate(0, -ButtonDown, 0);
            onButton = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
                onButton = false;
        }
    }
}
