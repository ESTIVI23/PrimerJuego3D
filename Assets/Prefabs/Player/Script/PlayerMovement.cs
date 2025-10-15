using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    /// <summary>
    /// fuerza utilizada para aplicar el movimiento
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Representa el tiempo que ha transcurrido desde la ultima aplicacion
    /// </summary>
    private float  tiempoDesdeUltimaFuerza;
    /// <summary>
    ///Indica cada cuanto tiempo debe aplicarse la fuerza 
    /// </summary>
    private float intervaloTiempo;

    /// <summary>
    /// inicia la velocidad aplicada en el movimiento 
    /// </summary>
    private float velocidadLateral;

    //------------------------------------------------------
    /// <summary>
    /// representa la strategia de movimiento   
    /// </summary>

    private IMovementStrategy strategy;
     
    #endregion





    #region Ciclo de vida 

    // Start is called before the first frame update
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0,0,300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 10f;

        SetStrategy(new MovimientoAcelerado());

    }

    

   


    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
            { 
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
        tiempoDesdeUltimaFuerza = 0f;
        }
    }


    #endregion







    #region Logica del Script

    public void MovePlayer(float input)
    {
        strategy.Move(transform, velocidadLateral, input); // aqui tambien pasamos la direcion para el ICommand
    }


    public void SetStrategy(IMovementStrategy strategy)
    { 
        this.strategy = strategy;
    }



    #endregion

}
