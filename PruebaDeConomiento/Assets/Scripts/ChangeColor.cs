using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    //Variables

    public GameObject GunObject;

    private int cont = 0;

    //Opciones de colores
    Color customColorOne = new Color(0.4f, 0.9f, 0.7f, 1.0f);
    Color customColorTwo = new Color(0.7f, 0.3f, 0.5f, 1.0f);
    Color customColorOThree = new Color(0.5f, 0.2f, 0.9f, 1.0f);

    //Carga los datos guardados
    private void Awake() {
        LoadData();
    }

    public void RotateColors(){

        var gunRenderer = GunObject.GetComponent<Renderer>();
        

        
        //Si el contador se pasa de los numeros que son opciones, vuelve a 0
        if(cont==3){
            cont=0;
        }

        // Cambia de color de acuerdo al contador
        switch(cont){

            case 0: 

            gunRenderer.material.color = customColorOne;
            Debug.Log(0);

            break;

            case 1: 
            
            gunRenderer.material.color = customColorTwo;
            Debug.Log(1);

            break;

            case 2: 
            
            gunRenderer.material.color = customColorOThree;
            Debug.Log(2);

            break;

        }

        cont++;


    }

    private void OnDestroy() {
        SaveData();
    }

    private void SaveData(){

        PlayerPrefs.SetInt("ColorArma", cont-1);

    }

    private void LoadData(){

        cont = PlayerPrefs.GetInt("ColorArma",0);
        Debug.Log("Llegue "+cont);

        RotateColors();

    }


}
