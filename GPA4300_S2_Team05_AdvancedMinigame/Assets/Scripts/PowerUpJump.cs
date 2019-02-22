using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : MonoBehaviour
{
    [HideInInspector] public PlayerControll player;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    private Rigidbody rb;

    public float JumpForce;
    private bool canJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider jump)
    {
        if (jump.gameObject == PlayerLeila)
        {
            if (canJump)
            {
                if (player.isGrounded)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
                    }
                }
                Debug.Log("jump");
            }
        }
        else if (jump.gameObject == PlayerDan)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
                player.isGrounded = false;
            }
        }
    }

    private void Update()
    {
        if (player.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, JumpForce, 0, ForceMode.Impulse);
            }
        }
        
    }
}
