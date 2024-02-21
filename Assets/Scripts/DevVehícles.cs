using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevVehícles : MonoBehaviour
{
    //public Transform spawnVehicles;
    //public int timeSpawn = 0;

    private void Update()
    {
        //Instantiate()
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Carro"))
        {
            other.transform.Translate(20,0,0);
        }
    }
}

