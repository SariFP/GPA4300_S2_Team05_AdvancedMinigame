using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float MoveSpeed;
    public int index;
    Animator anim;

    public GameObject LeilaCam;
    public GameObject DanCam;
    public bool camSwitch = false;

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
            float InputX = transform.position.x + Input.GetAxis("Horizontal_" + index) * MoveSpeed * Time.deltaTime;
            float InputY = transform.position.z + Input.GetAxis("Vertical_" + index) * MoveSpeed * Time.deltaTime;

            transform.position = new Vector3(InputX, transform.position.y, InputY);
            //isMoving = true;
        }

        //if (isMoving && isGrounded)
        //{
        //    anim.SetBool("isWalking", isMoving);
        //}

        if (Input.GetButtonDown("CameraSwitch"))
        {
            camSwitch = !camSwitch;
            DanCam.SetActive(camSwitch);
            LeilaCam.SetActive(!camSwitch);
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
