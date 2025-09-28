using UnityEngine;

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
    #endregion


    #region Ciclo de vida del script


    // Start is called before the first frame update
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0,300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;

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



}
