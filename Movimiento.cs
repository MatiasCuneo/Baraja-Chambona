using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform[] direcciones;
    public float velocidad = 5f;
    public int indexDireccion = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Moverse();
        }
    }

    void Moverse()
    {
        if (direcciones.Length == 0)
        {
            return;
        }

        Transform direccionActual = direcciones[indexDireccion];

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, direccionActual.position, velocidad * Time.deltaTime);

        if (gameObject.transform.position == direccionActual.position)
        {
            indexDireccion++;
        }
    }
}
