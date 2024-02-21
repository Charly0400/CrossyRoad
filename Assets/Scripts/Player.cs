using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class Player : MonoBehaviour
{
    public GameObject uiMuerte;

    [SerializeField]
    private float forceMovement = 5f;
    private ActionPlayerInputs player;
   

    private void Awake()
    {
        player = new ActionPlayerInputs();
        player.Enable();
    }

    void Start()
    {
       // rb = GetComponent<Rigidbody>();
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
            case "a":
                transform.Translate(Vector3.left * forceMovement);
                break;
            case "d":
                transform.Translate(Vector3.right * forceMovement);
                break;
        }
        Debug.Log(tecla);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Carro"))
        {
            // Detener el juego
            Time.timeScale = 0f;

            player.Disable();
            uiMuerte.SetActive(true);
        }
    }

}
