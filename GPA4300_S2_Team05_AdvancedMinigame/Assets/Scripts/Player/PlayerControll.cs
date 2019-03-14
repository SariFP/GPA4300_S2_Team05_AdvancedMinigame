using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float MoveSpeed;
    public int index;
    Animator anim;
    private Rigidbody rb;

    /*[HideInInspector]*/ public bool isGrounded;
    /*[HideInInspector]*/ public bool controllable;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (isGrounded && controllable)
        {
            //controllable = true;
            float InputX = transform.position.x + Input.GetAxis("Horizontal_" + index) * MoveSpeed * Time.deltaTime;
            float InputZ = transform.position.z + Input.GetAxis("Vertical_" + index) * MoveSpeed * Time.deltaTime;
            transform.position = new Vector3(InputX, transform.position.y, InputZ);
        }

        //if (controllable)
        //{
        //    anim.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
        //    anim.SetFloat("yVelocity", Mathf.Abs(rb.velocity.y));
        //    anim.SetBool("isGrounded", isGrounded);
        //}
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
