using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShrink : MonoBehaviour
{
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public Vector3 currentScale;

    private void Start()
    {
        //currentScale = Mathf.Clamp(0.7f, 0.3f, 1f);
    }

    private void OnTriggerEnter(Collider shrink)
    {
        if (shrink.gameObject == PlayerLeila)
        {
            PlayerLeila.transform.localScale = new Vector3(-0.3f, -0.3f, -0.3f);
        }
        else if (shrink.gameObject == PlayerDan)
        {
            PlayerDan.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
    }

    private void OnTriggerExit(Collider shrink)
    {
        if (shrink.gameObject == PlayerLeila)
        {
            PlayerLeila.transform.localScale = currentScale;
        }
        else if (shrink.gameObject == PlayerDan)
        {
            PlayerDan.transform.localScale = currentScale;
        }
    }
}
