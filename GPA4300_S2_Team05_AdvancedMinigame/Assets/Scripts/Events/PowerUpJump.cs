using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : MonoBehaviour
{
    [HideInInspector] public PlayerControll player;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    Animator anim;

    public float JumpForce;
    private bool leilaCanJump;
    private bool danCanJump;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip JumpSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider jump)
    {
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
            anim.SetTrigger("Jump");

        }
        else if (danCanJump && Input.GetButtonDown("Jump"))
        {
            PlayerDan.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            AudioSource.PlayClipAtPoint(JumpSound, PlayerDan.transform.position, Volume);
            anim.SetTrigger("Jump");
        }
    }
}
