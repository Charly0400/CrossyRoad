using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mapa : MonoBehaviour
{
    [SerializeField]
    private float forceMovement = 5f;
    private ActionPlayerInputs mapa;

    private void Awake()
    {
        mapa = new ActionPlayerInputs();
        mapa.Enable();
    }

    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        mapa.Standard.Movement.performed += MapMovement;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MapMovement(InputAction.CallbackContext context)
    {
        string tecla = context.control.name;
        switch (tecla)
        {
            case "w":
                transform.Translate(Vector3.back * forceMovement);
                break;
            case "s":
                transform.Translate(Vector3.forward * forceMovement);
                break;
        }
        Debug.Log(tecla);
    }   
}
