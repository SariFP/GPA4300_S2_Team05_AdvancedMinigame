using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShrink : MonoBehaviour
{
    [HideInInspector] public PlayerControll player;
    [HideInInspector] public bool little;

    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    private void OnTriggerEnter(Collider shrink)
    {
        if (shrink.gameObject == PlayerLeila)
        {
            PlayerLeila.transform.localScale += new Vector3(-0.4f, -0.4f, -0.4f);
        }
        else if (shrink.gameObject == PlayerDan)
        {
            PlayerDan.transform.localScale += new Vector3(-0.4f, -0.4f, -0.4f);
        }
    }
}
