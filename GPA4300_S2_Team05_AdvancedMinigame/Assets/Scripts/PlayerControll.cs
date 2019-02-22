﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float MoveSpeed;
    public int index;
    Animator anim;

    public bool isGrounded;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded)
        {
            float xNew = transform.position.x + Input.GetAxis("Horizontal_" + index) * MoveSpeed * Time.deltaTime;
            float zNew = transform.position.z + Input.GetAxis("Vertical_" + index) * MoveSpeed * Time.deltaTime;

            transform.position = new Vector3(xNew, transform.position.y, zNew);
            //isMoving = true;
        }

        if (isMoving)
        {
            anim.SetBool("isWalking", isMoving);
        }
        else
        {
            anim.SetTrigger("stopped");
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
