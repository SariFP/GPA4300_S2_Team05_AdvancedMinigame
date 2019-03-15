using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnPlatform : MonoBehaviour
{
    private PlatformEvent platE;


    private void Start()
    {
        platE = GetComponentInParent<PlatformEvent>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && platE.t < 1)
        {
            other.transform.parent = transform;
        }
        if (other.gameObject.tag == "Player" && platE.t >= 1)
        {
            other.transform.parent = null;
        }
    }
}
