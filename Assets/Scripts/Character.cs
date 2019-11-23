using BeardedManStudios.Forge.Networking.Generated;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Character : MonoBehaviour
{
    private CharacterController _controller;
    Animator animator;
    public float speed = 16.0F;
    public float jumpSpeed = 3.0F;
    public float gravity = -19.62F;
    public float Health = 1;

    public GameObject Hand;
    public GameObject Axe;
    public GameObject playerCamera;

    private Vector3 moveDirection = Vector3.zero;
    private bool interrupteur = false;

    private float startTime;
    public float duration = 0.08f;
    public  Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4F;
    public bool isGrounded;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public RaycastHit hit;                                  //use this if you want to acces objects that are hit with the raycast
    public float distance = 0.1f;                       //set this to go beyond your collider
    public Vector3 direction = new Vector3(0f, -1f, 0f);
    public float rayLength = 0.1f;
    public bool m_hitWall;
    public bool m_isGrounded;
    public float m_finalRayLength;
    public RaycastHit m_hitInfo;

    void Start()
    {

        _controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        isGrounded = false;
        m_finalRayLength = rayLength + _controller.center.y;
    }

    void Update()
    {
       
        isGrounded = _controller.isGrounded;
        yaw += speedH * (Input.GetAxis("View X"));
        if (isGrounded)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            moveDirection = transform.right * x + transform.forward * y;

            animator.SetFloat("Forward", y);
            animator.SetFloat("Strafing", x);
            if (animator.GetBool("Sprinting"))
                moveDirection *= 3;
            moveDirection *= speed;
           

           
        }
        animator.SetBool("Attack", false);
        animator.SetBool("Jumping", false);
        if (Input.GetButton("Fire2"))
        {
            animator.SetBool("Attack", true);
        }

        if (Input.GetButton("Fire3"))
        {
            this.Axe.SetActive(!this.Axe.active);
        }
            if (Input.GetButton("Fire1"))
        {
            if (isGrounded)
            {
                animator.SetBool("Jumping", true);
                moveDirection.y = Mathf.Sqrt(jumpSpeed * -2 * gravity);
            }
        }
        if (Input.GetButton("Sprint"))
        {
            animator.SetBool("Sprinting", true);
        }else
            animator.SetBool("Sprinting", false);
        moveDirection.y += gravity * Time.deltaTime;
        _controller.Move(moveDirection * Time.deltaTime);
        transform.eulerAngles = new Vector3(0.0F, yaw, 0.0f);
    }

    public float getHealth()
    {
        return this.Health;
    }

}