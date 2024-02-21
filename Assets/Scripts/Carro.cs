using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{

    public int velocidad; // Velocidad del coche

    /*public int velocidadpublica // Propiedad para obtener y asignar la velocidad del coche
    {
        get { return velocidad; }
        set { velocidad = value; }
    }*/

    private void Update()
    {
        transform.Translate(-velocidad * Time.deltaTime, 0, 0);
    }


}
