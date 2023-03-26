using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHat : MonoBehaviour
{
    //Variables

    public GameObject PrimerSombrero;
    public GameObject SegundoSombrero;
    public GameObject TercerSombrero;
    private static int cont = 0;

    private void Awake() {
        LoadData();
    }

    public void RotateClothes(){

        
        //Si el contador se pasa de los numeros que son opciones, vuelve a 0
        if(cont==3){
            cont=0;
        }

        // Cambia de sombrero de acuerdo al contador
        switch(cont){

            case 0: 
            
            PrimerSombrero.SetActive(true);
            SegundoSombrero.SetActive(false);
            TercerSombrero.SetActive(false);
            Debug.Log(cont);

            break;

            case 1: 
            
            PrimerSombrero.SetActive(false);
            SegundoSombrero.SetActive(true);
            TercerSombrero.SetActive(false);
            Debug.Log(cont);

            break;

            case 2: 
            
            PrimerSombrero.SetActive(false);
            SegundoSombrero.SetActive(false);
            TercerSombrero.SetActive(true);
            Debug.Log(cont);

            break;
            
        }

        cont++;


    }

    private void OnDestroy() {
        SaveData();
    }

    private void SaveData(){

        PlayerPrefs.SetInt("Sombrero", cont-1);

    }

    private void LoadData(){

        cont = PlayerPrefs.GetInt("Sombrero",0);
        Debug.Log("Llegue "+cont);

        RotateClothes();

    }
}
