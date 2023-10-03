using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float forceModifier;

    [Header("Vehicle Prefab Variables")]
    [SerializeField] float forwardValue;
    [SerializeField] float turnValue;
    [SerializeField] float forwardMofifier;
    [SerializeField] float turnMofifier;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Forward movement
        transform.Translate(Vector3.forward * forwardValue * Time.deltaTime);
        rb.AddRelativeForce(Vector3.forward * forwardValue * forceModifier * Time.deltaTime);
        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        localVelocity.x = 0f;
        rb.velocity = transform.TransformDirection(localVelocity);

        transform.Rotate(Vector3.up * turnValue * Time.deltaTime);
    }

    public void OnDrive(InputAction.CallbackContext context)
    {
        forwardValue = context.ReadValue<float>();
        forwardValue *= forwardMofifier;
    }

    public void OnTurn(InputAction.CallbackContext context)
    {
        turnValue = context.ReadValue<float>();
        turnValue *= turnMofifier + forwardValue;
    }
}
