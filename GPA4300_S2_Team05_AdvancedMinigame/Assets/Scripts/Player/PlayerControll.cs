using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float MoveSpeed;
    public float turnAngle;
    public int index;
    Animator anim;
    float InputX;
    float InputZ;

    private Vector3 moveDirection = Vector3.zero;

    [HideInInspector] public bool isGrounded;
    /*[HideInInspector]*/ public bool controllable;

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
        }

        if (Input.GetAxis("Vertical_" + index) != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
            anim.SetBool("isWalking", false);

        if (Input.GetAxis("Horizontal_" + index) != 0)
        {
            turnAngle += Input.GetAxis("Horizontal_" + index);
            transform.eulerAngles = new Vector3(0, turnAngle, 0);
            //transform.RotateAroundLocal(Vector3.up, turnSpeed * Time.deltaTime);
            anim.SetBool("WalkLeft", true);
        }
        else
            anim.SetBool("WalkLeft", false);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
