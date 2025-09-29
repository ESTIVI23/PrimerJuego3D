using UnityEngine;
using UnityEngine.UIElements;

/// <summary> 
/// Permite el comportamiento del movimiento del jugador
/// </summary>
public class PlayerMovemen : MonoBehaviour
{


    #region Aribuos

    
    /// <summary>
    /// Fuerza uttilizada para aplicar movimiento 
    /// </summary>

    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Repersenta el ttiempo que ha transcurrido
    /// desde la ultima aplicacion de fuerza 
    /// </summary>
    private float tiempoDesdeUltimaFuerza;
    /// <summary>
    /// Iindica cada cuanto tiempo debe aplicarse la fuerza
    /// </summary>
    private float intervaloTiempo;

    /// <summary>
    /// Inicia la velocidad aplicada en el movimiento lateral
    /// </summary>
    private float velocidadLatetral;

    /// <summary>
    /// Representa la estrategia de movimiento
    /// </summary>
    private IMovementStrategy strategy;

    #endregion


    #region Ciclo de vida del script


    // Start is called before the first frame update
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0,300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLatetral = 10f;
        SetStrategy(new MovimientoAceledaro());
    }

    private void Update()
    {

        strategy.Move(transform, velocidadLatetral);  
    }
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if(tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }

}



    #endregion


    #region Logica del Script


    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }



    #endregion
}
