using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPuzzle : MonoBehaviour
{
    //variables

    // Update is called once per frame
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "chest"){

            Debug.Log("funciona");

        }
    }
}
