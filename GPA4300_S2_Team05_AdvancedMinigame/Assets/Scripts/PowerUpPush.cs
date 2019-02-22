using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPush : MonoBehaviour
{
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    private void OnCollisionEnter(Collision push)
    {
        if (push.gameObject == PlayerLeila)
        {

        }
        else if (push.gameObject == PlayerDan)
        {

        }
    }
}
