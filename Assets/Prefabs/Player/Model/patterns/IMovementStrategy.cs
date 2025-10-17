
using UnityEngine;



// este  es una interface no una clase 
public interface IMovementStrategy
{
                                         
    public void Move(Transform transform,float speed, float direccion); // metodo abstracto  // para el ICommand agregamos la direccion
    
}
// esto seria una implementacion de Strategy 