using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEvent : MonoBehaviour
{
    public List<Button> button = new List<Button>();

    [Header("LerpTry")]
    public Transform startMark;
    public Transform endMark;

    public float speed = 1.0f;
    public float t;


    private void Update()
    {
        if (button.Capacity == 1)
        {
            if (button[0].onButton)
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
        else
        {
            if (button[0].onButton || button[1].onButton)
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
    }
}
