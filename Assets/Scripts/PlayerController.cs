using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Vehicle Prefab")]
    [SerializeField] GameObject vehicleModel;
    [SerializeField] float speed; // If we're gonna add velocity [THEN HERE]

    public bool IsMoving;

    private Rigidbody rb;
    private Vector2 movementInput; // Maybe can be used moveInput.x instead of
                               // separating it into 2 vars
    private Vector3 movementValue;
    private Quaternion movementRotation;

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
            transform.Rotate(movementInput.x, 0.0f, 0.0f, Space.World); // This is not working properly
            rb.AddForce(movementValue * speed * Time.deltaTime);
        }
        //rb.AddForce(movement * speed * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        movementValue = new Vector3(0.0f, 0.0f, movementInput.y);
        IsMoving = movementInput != Vector2.zero;
    }
}
