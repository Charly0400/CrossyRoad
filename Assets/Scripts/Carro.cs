using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    [SerializeField]
    private float velocidad;

    private void Start()
    {
        velocidad = Random.Range(3, 6);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
    }


}
