using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{


    private Vector3 offset;
    private PlayerController controller; // es el scrpts que vamos a usar para acceder al player 
  
    void Start()
    {
         offset = new Vector3(0,1,-5);
        controller = FindObjectOfType<PlayerController>(); // usamos el -- FindObjectOfType<PlayerController> Para que busque el scrpt player controler es solo un objeto de playercontroller


    }

    private void LateUpdate()
    {
        gameObject.transform.position = controller.transform.position + offset;
    }
}
