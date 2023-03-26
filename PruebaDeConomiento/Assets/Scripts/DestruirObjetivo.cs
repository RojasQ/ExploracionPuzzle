using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestruirObjetivo : MonoBehaviour
{
    public static int contador = 0;

    // Cuenta los objetivos destruidos para validar que se le entregue el item
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Objetivo"){
            Destroy(other.gameObject);
            Destroy(gameObject);
            contador+= 1;
            Debug.Log(contador);
        }
    }

}
