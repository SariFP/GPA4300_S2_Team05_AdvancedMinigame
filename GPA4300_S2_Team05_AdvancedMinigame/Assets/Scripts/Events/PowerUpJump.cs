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
        if (leilaCanJump && Input.GetKeyDown(KeyCode.Space))
        {
            PlayerLeila.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            Debug.Log("Jumped");
            //leilaCanJump = false;
        }
        else if (danCanJump && Input.GetKeyDown(KeyCode.Space))
        {
            PlayerDan.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            Debug.Log("Jumped");
        }
    }
}
