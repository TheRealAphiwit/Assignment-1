using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Vehicle Prefab")]
    [SerializeField] GameObject vehicleModel;
    [SerializeField] float movementSpeed; // If we're gonna add velocity [THEN HERE]
    [SerializeField] float rotationSpeed;

    public bool IsMoving;

    private Rigidbody rb;
    private Vector2 movementInput; // Maybe can be used moveInput.x instead of
                               // separating it into 2 vars
    private float movementValue;
    private float turnValue;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (IsMoving)
        {
            Debug.Log("IsMoving = true");
            rb.AddRelativeForce(Vector3.forward * movementValue * movementSpeed * Time.deltaTime);
            Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
            localVelocity.x = 0f;
            rb.velocity = transform.TransformDirection(localVelocity);

            rb.AddTorque(Vector3.up * turnValue * rotationSpeed * movementSpeed * Time.deltaTime);
        }
        //rb.AddForce(movement * speed * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        movementValue = movementInput.y;
        turnValue = movementInput.x;
        IsMoving = movementInput != Vector2.zero;
    }
}
