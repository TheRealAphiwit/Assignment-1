using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHUDManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    [SerializeField] PlayerController playerController1;
    [SerializeField] PlayerController playerController2;

    // Start is called before the first frame update
    void Start()
    {
        playerController1 = player1.GetComponent<PlayerController>();
        playerController2 = player2.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
