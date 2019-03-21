﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public ScriptableObjectClothes Cloth;

    public float MoveSpeed;
    public float TurnSpeed;
    public float turnAngle;
    public int index;
    Animator anim;

    private Vector3 moveDirection = Vector3.zero;

    [HideInInspector] public bool isGrounded;
    [HideInInspector] public bool controllable;

    [Header("BodyParts")]
    public GameObject Body;
    public GameObject Hair;
    public GameObject Head;
    public GameObject Eyes;
    public GameObject Mask;
    public GameObject Torso;
    public GameObject Outer;
    public GameObject Backpack;
    public GameObject Hands;
    public GameObject Legs;
    public GameObject Feets;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        Init();
    }

    private void Init()
    {
        Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Hair.mesh;
        Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Hair.material;

        Head.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Head.mesh;
        Head.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Head.material;

        Eyes.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Eyes.mesh;
        Eyes.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Eyes.material;

        Mask.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Mask.mesh;
        Mask.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Mask.material;

        Torso.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Torso.mesh;
        Torso.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Torso.material;

        Outer.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Outer.mesh;
        Outer.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Outer.material;

        Backpack.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Backpack.mesh;
        Backpack.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Backpack.material;

        Hands.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Hands.mesh;
        Hands.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Hands.material;

        Legs.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Legs.mesh;
        Legs.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Legs.material;

        Feets.GetComponent<SkinnedMeshRenderer>().sharedMesh = Cloth.Feets.mesh;
        Feets.GetComponent<SkinnedMeshRenderer>().sharedMaterial = Cloth.Feets.material;
    }

    void Update()
    {
        if (isGrounded && controllable)
        {
            float InputX = Input.GetAxis("Horizontal_" + index) * TurnSpeed;
            float InputZ = Input.GetAxis("Vertical_" + index) * MoveSpeed;

            if (Input.GetAxis("Horizontal_" + index) != 0)
            {
                turnAngle += (InputX * Time.deltaTime);
                transform.eulerAngles = new Vector3(0, turnAngle, 0);
            }
            transform.Translate(0f, 0f, InputZ * Time.deltaTime);
            anim.SetFloat("MoveSpeed", Mathf.Abs(InputZ));
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
