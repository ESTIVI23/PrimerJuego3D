
using UnityEngine;



//es una clase pero implementamos una interface 
public class MovimientoLateral: IMovementStrategy
{
    public void Move(Transform transform, float speed, float direccion  ) // lo mismo agregamos la direccion para el ICommand
    {
        // para que se pueda mover con las flechas o -- a y d --
        //float direccion = Input.GetAxis("Horizontal");
        transform.Translate(direccion * speed * Time.deltaTime, 0, 0);
    }
}

// es una clase pero no es un script