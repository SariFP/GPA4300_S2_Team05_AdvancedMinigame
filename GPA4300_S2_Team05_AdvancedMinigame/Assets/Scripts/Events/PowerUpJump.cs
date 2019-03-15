using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : MonoBehaviour
{
    [HideInInspector] public PlayerControll player;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public float JumpForce;
    private bool leilaCanJump;
    private bool danCanJump;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip JumpSound;
    public AudioClip UpgradeSound;

    private void OnTriggerEnter(Collider jump)
    {
        AudioSource.PlayClipAtPoint(UpgradeSound, PlayerLeila.transform.position, Volume);
        if (jump.gameObject == PlayerLeila)
        {
            leilaCanJump = true;
        }
        else if (jump.gameObject == PlayerDan)
        {
            danCanJump = true;
        }
    }

    private void Update()
    {
        if (leilaCanJump && Input.GetButtonDown("Jump"))
        {
            PlayerLeila.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            AudioSource.PlayClipAtPoint(JumpSound, PlayerLeila.transform.position, Volume);
            PlayerLeila.GetComponent<Animator>().SetTrigger("Jump");

        }
        else if (danCanJump && Input.GetButtonDown("Jump"))
        {
            PlayerDan.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            AudioSource.PlayClipAtPoint(JumpSound, PlayerDan.transform.position, Volume);
            PlayerDan.GetComponent<Animator>().SetTrigger("Jump");
        }
    }
}
