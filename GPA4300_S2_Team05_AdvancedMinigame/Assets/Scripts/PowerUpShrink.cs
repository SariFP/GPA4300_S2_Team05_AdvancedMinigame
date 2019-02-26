using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShrink : MonoBehaviour
{
    [HideInInspector] public PlayerControll player;
    [HideInInspector] public bool little;

    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public float currentScale;

    private void Start()
    {
        currentScale = Mathf.Clamp(0.7f, 0.3f, 1f);
    }

    private void OnTriggerEnter(Collider shrink)
    {
        if (shrink.gameObject == PlayerLeila)
        {
            PlayerLeila.transform.localScale += new Vector3(-0.7f, -0.7f, -0.7f);
        }
        else if (shrink.gameObject == PlayerDan)
        {
            PlayerDan.transform.localScale += new Vector3(-0.4f, -0.4f, -0.4f);
            //PlayerDan.transform.localScale = currentScale + new Vector3(-0.4f, -0.4f, -0.4f);
        }
    }
}
