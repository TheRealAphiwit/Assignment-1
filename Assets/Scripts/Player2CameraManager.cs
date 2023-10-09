using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2CameraManager : MonoBehaviour
{
    public Rigidbody player2Vehicle;
    public AudioListener player2AudioListener;
    public Camera player2Camera;

    void Start()
    {
        Debug.Log("P2CM is running!");
        player2Vehicle = GetComponentInChildren<Rigidbody>();
        player2Camera = player2Vehicle.GetComponentInChildren<Camera>();

        player2AudioListener = player2Camera.GetComponent<AudioListener>();
        Destroy(player2AudioListener);

        player2Camera.rect = new Rect(0.5f,0,0.5f,1f);
    }
}
