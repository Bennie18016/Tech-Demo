using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Creating important variables
    float speed = 6f;
    [SerializeField] Camera playercamera;
    float sensitivty = 2f;
    float gravity = 20.0f;
    float xlimt = 45.00f;
    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    void Start()
    {
        //Lets me use the character controller in the code
        characterController = GetComponent<CharacterController>();

        //Hides the cursor and locks it so it doesn't move from the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //Makes the direction we can move. This is to stop us from being able to fly upwards if we ae looking into the sky and holding W
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        //Creates the amount we are going to move by.
        float curSpeedX = speed * Input.GetAxis("Vertical");
        float curSpeedY = speed * Input.GetAxis("Horizontal");
        //Part one of moving, 
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        //Checks if we are in the air or on the ground
        if (!characterController.isGrounded)
        {
            //Moves us to the ground if we are in the air
            moveDirection.y -= gravity * Time.deltaTime;
        }

        //Actually moves us
        characterController.Move(moveDirection * Time.deltaTime);

        //Moves our camera where our mouse goes
        rotationX += -Input.GetAxis("Mouse Y") * sensitivty;
        //Stops us from doing barrel rolls
        rotationX = Mathf.Clamp(rotationX, -xlimt, xlimt);
        playercamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * sensitivty, 0);
    }

}
