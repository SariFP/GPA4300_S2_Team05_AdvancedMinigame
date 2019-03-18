using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float MoveSpeed;
    public int index;
    Animator anim;
    float InputX;
    float InputZ;

    private Vector3 moveDirection = Vector3.zero;

    /*[HideInInspector]*/ public bool isGrounded;
    /*[HideInInspector]*/ public bool controllable;
    /*[HideInInspector]*/ public bool isWalking;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (isGrounded && controllable)
        {
            /*float*/ InputX = transform.position.x + Input.GetAxis("Horizontal_" + index) * MoveSpeed * Time.deltaTime;
            /*float*/ InputZ = transform.position.z + Input.GetAxis("Vertical_" + index) * MoveSpeed * Time.deltaTime;
            transform.position = new Vector3(InputX, transform.position.y, InputZ);
            isWalking = true;
        }
        if (isWalking)
        {
            //anim.SetBool("isWalking", isWalking);
            anim.SetFloat("xVelocity", InputX);
            anim.SetFloat("yVelocity", InputZ);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
