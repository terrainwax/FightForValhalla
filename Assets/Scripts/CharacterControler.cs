using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class CharacterControler : MonoBehaviour
{

    [Header("Script refrences")]
    //[SerializeField]
    //the health system script
    //private HealthSystem hp;

    [Header("CharacterControls")]
    //movement speed
    [SerializeField]
    private float speed = 3.0f;

    //gravity
    [SerializeField]
    private float gravity = -19.6f;

    //max allowed velocity change
    [SerializeField]
    private float maxVelocityChange = 10.0f;

    //jump height
    [SerializeField]
    private float jumpHeight = 1.0f;

    //The player model
    [SerializeField]
    private GameObject playerBody;

    [SerializeField]
    private CharacterController controller;

    public LayerMask groundMask;

    public float rayLength = 0.1f;

    public Transform groundCheck;

    private Vector3 targetVelocity;
    private bool canJump = true;
    [SerializeField]
    private bool grounded = false;

    //can the player move?
    private bool canMove = true;

    public float speedH = 2.0f;

    public float sensitivity = 100;

    private float yaw = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Don't do anything if we can't move
        if (!canMove)
        {
            return;
        }
        grounded = Physics.Raycast(groundCheck.position, Vector2.down, rayLength, groundMask);
         yaw += speedH * (Input.GetAxis("View X"));
        if (grounded)
        {
            // Calculate how fast we should be moving
            targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
            //use the playerbody's transform if it's defined
            if (playerBody)
            {
                targetVelocity = playerBody.transform.TransformDirection(targetVelocity);
            }
            else
            {
                targetVelocity = transform.TransformDirection(targetVelocity);
            }
            targetVelocity *= speed;

            // Apply a force that attempts to reach our target velocity
            

            // Jump
            if (Input.GetButton("Fire1"))
            {
                targetVelocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            }
        }
        // We apply gravity manually for more tuning control
        controller.Move(targetVelocity);
        controller.transform.eulerAngles = new Vector3(0.0F, yaw * sensitivity, 0.0f);
    }
    private void Update()
    {
        targetVelocity = new Vector3(0, 0, 0);
        targetVelocity.y += gravity * Time.deltaTime;
        controller.Move(targetVelocity * Time.deltaTime);
    }


    float CalculateJumpVerticalSpeed()
    {
        // From the jump height and gravity we deduce the upwards speed 
        // for the character to reach at the apex.
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }

}
