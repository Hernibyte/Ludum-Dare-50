using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float gravity = -9.81f;

    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 0.4f;
    [SerializeField] LayerMask groundLayerMask;

    CharacterController characterController;
    bool isGrounded;
    Vector3 velocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
        FisicsxD();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        Vector3 newPos = transform.right * x + transform.forward * y;
        characterController.Move(newPos);
    }

    void FisicsxD()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayerMask);

        if (isGrounded && velocity.y < 0)
            velocity.y = -2f;

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}
