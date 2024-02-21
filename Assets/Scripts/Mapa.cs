using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mapa : MonoBehaviour
{
    [SerializeField]
    private float forceMovement = 5f;
    private ActionPlayerInputs mapa;
   

    [Header("SpawnPisos")]
    private int carril = 0;
    public GameObject[] pisos;
    [SerializeField]
    private int pisosDiferencia;
    public Transform parentObject;

    /*[Header("Coches")]
    public GameObject cochePrefab; // Prefab del coche a instanciar
    public float tiempoSpawn; */

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
            //StartCoroutine(SpawnearCochesEnCarril(carril));
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
    

}         /* 
             private IEnumerator SpawnearCochesEnCarril(int carril)
            {
                int numPisos = parentObject.childCount;

                while (true)
                {
                    // Asegurarse de que el carril esté dentro de los límites
                    if (carril >= 0 && carril < numPisos)
                    {
                        // Obtener el transform del punto de spawn dentro del piso actual
                        Transform puntoDeSpawn = GetPuntoDeSpawnEnCarril(carril);

                        if (puntoDeSpawn != null)
                        {
                            // Calcular posición de spawn
                            Vector3 spawnPosition = puntoDeSpawn.position;

                            // Obtener la velocidad de los coches para este carril
                            int velocidadCoches = Random.Range(3, 10);

                            // Instanciar coche
                            GameObject coche = Instantiate(cochePrefab, spawnPosition, Quaternion.identity, parentObject);
                            Carro cocheComponent = coche.GetComponent<Carro>();

                            // Asignar velocidad del carril al coche
                            cocheComponent.velocidadpublica = velocidadCoches;
                        }
                    }

                    // Esperar un tiempo antes de instanciar el siguiente coche
                    yield return new WaitForSeconds(tiempoSpawn);
                }
            }

            private Transform GetPuntoDeSpawnEnCarril(int carril)
            {
                // Obtener el piso actual
                GameObject pisoActual = parentObject.GetChild(carril).gameObject;

                if (pisoActual != null)
                {
                    // Buscar y retornar el transform del punto de spawn dentro del piso actual
                    return pisoActual.transform.Find("PuntoDeSpawn");
                }

                return null;
            }
            */

