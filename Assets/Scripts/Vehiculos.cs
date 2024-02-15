using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculos : MonoBehaviour
{
    public Transform tranformIzq;
    public Transform tranformDer;
    private Vector3 directionIzq;
    private Vector3 directionDer;

    public int velmin;
    public int velmax;
    private int currentvel;
    private int side;
    
    void Start()
    {
        side = Random.Range(0, 2);
        currentvel = Random.Range(velmin,velmax);
        sideChoice();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void sideChoice()
    {
        if (side == 0)
        {
            dirIzquierda();
        }

        if (side == 1)
        {
            dirDerecha();
        }

    }

    public void dirIzquierda()
    {
        transform.Translate(Vector3.left * currentvel * Time.deltaTime);
    }
    public void dirDerecha()
    {
        transform.Translate(Vector3.right * currentvel * Time.deltaTime);
    }

}



