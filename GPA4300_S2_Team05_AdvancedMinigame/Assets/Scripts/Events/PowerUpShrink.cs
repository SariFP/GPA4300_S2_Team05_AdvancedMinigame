using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShrink : MonoBehaviour
{
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public Vector3 currentScale;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip ShrinkSound;
    public AudioClip GrowSound;

    private void Start()
    {
        //currentScale = Mathf.Clamp(0.7f, 0.3f, 1f);
    }

    private void OnTriggerEnter(Collider shrink)
    {
        if (shrink.gameObject == PlayerLeila)
        {
            PlayerLeila.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            AudioSource.PlayClipAtPoint(ShrinkSound, PlayerLeila.transform.position, Volume);
        }
        else if (shrink.gameObject == PlayerDan)
        {
            PlayerDan.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            AudioSource.PlayClipAtPoint(ShrinkSound, PlayerDan.transform.position, Volume);
        }
    }

    private void OnTriggerExit(Collider shrink)
    {
        if (shrink.gameObject == PlayerLeila)
        {
            PlayerLeila.transform.localScale = currentScale;
            AudioSource.PlayClipAtPoint(GrowSound, PlayerLeila.transform.position, Volume);
        }
        else if (shrink.gameObject == PlayerDan)
        {
            PlayerDan.transform.localScale = currentScale;
            AudioSource.PlayClipAtPoint(GrowSound, PlayerDan.transform.position, Volume);
        }
    }
}
