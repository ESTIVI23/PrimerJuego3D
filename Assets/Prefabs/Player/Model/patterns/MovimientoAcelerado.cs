using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAcelerado: IMovementStrategy
{

    private float velocidadaActual = 0f;
    private float aceleracion = 2f;


    public void Move(Transform transform, float speed, float direccion) //tambien agregamos la direccion 
    {
        //velocidadaActual += Input.GetAxis("Horizontal") * aceleracion * Time.deltaTime;
        velocidadaActual += direccion * aceleracion * Time.deltaTime; // modicicado para el ICommand 
        velocidadaActual = Mathf.Clamp(velocidadaActual, -speed, speed);
        transform.Translate(velocidadaActual * Time.deltaTime, 0, 0);

    }
}
