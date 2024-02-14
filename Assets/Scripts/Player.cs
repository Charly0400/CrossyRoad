using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float jumpForce = 5f;
    private ActionPlayerInputs player;

    private void Awake()
    {
        player = new ActionPlayerInputs();
        player.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player.Standard.Movement.performed += PlayerMovement;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerMovement(InputAction.CallbackContext context)
    {
        string tecla = context.control.name;
        switch (tecla)
        {
            case "w":
               // transform.position * jumpForce;
                break;
            case "s":
                //transform.position
                break;
            case "a":
                break;
            case "d":
                break;
        }
        Debug.Log(tecla);
    }
}
