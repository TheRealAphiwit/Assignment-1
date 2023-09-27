using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Vehicle Prefab")]
    [SerializeField] GameObject vehicleModel;
    [SerializeField] Rigidbody rb;

    public bool IsMoving { get; private set; }
    public float speed = 10f;


    private Vector2 moveInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

        IsMoving = moveInput != Vector2.zero;
    }
}
