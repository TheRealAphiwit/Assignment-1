using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Variables")]
    [SerializeField] Rigidbody rb;
    [SerializeField] float forwardValue;
    [SerializeField] float turnValue;
    [SerializeField] float speed;
    [SerializeField] float turnMofifier;
    [SerializeField] float forceModifier;

    [Header("Status Variables")]
    public float maxHealth;
    public float health;
    public float defense;
    public float speedMod;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        if (rb != null)
        {
            Debug.Log("rb aquired!");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Forward movement
        rb.transform.Translate(Vector3.forward * forwardValue * Time.deltaTime);
        //rb.AddRelativeForce(Vector3.forward * forwardValue * forceModifier * Time.deltaTime);
        //Vector3 localVelocity = rb.transform.InverseTransformDirection(rb.velocity);
        //localVelocity.x = 0f;
        //rb.velocity = rb.transform.TransformDirection(localVelocity);

        rb.transform.Rotate(Vector3.up * turnValue * Time.deltaTime);
    }

    public void OnDrive(InputAction.CallbackContext context)
    {
        forwardValue = context.ReadValue<float>();
        forwardValue *= speed + speedMod;
    }

    public void OnTurn(InputAction.CallbackContext context)
    {
        turnValue = context.ReadValue<float>();
        turnValue *= turnMofifier + forwardValue;
    }
}
