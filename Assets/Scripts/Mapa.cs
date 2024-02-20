using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mapa : MonoBehaviour
{
    [SerializeField]
    private float forceMovement = 5f;
    private ActionPlayerInputs mapa;

    [Header ("SpawnPisos")]
    private int carril = 0;
    public GameObject[] pisos;
    [SerializeField]
    private int pisosDiferencia;
    public Transform parentObject;

    private void Awake()
    {
        mapa = new ActionPlayerInputs();
        mapa.Enable();
    }

    void Start()
    {
        for (int i = 0; i < pisosDiferencia; i++)
        {
            CrearPiso();
        }

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
                CrearPiso();
                break;
            case "s":
                transform.Translate(Vector3.forward * forceMovement);
                break;
        }
        Debug.Log(tecla);
    }   

    public void CrearPiso()
    {
        //Instantiate(pisos[Random.Range(0, pisos.Length)], Vector3.forward * carril, Quaternion.identity);
        Vector3 spawnPosition = parentObject.position + Vector3.forward * carril;
        Instantiate(pisos[Random.Range(0, pisos.Length)], spawnPosition, Quaternion.identity, parentObject); 
        carril++;
    }
}
