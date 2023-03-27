using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ShowPrize : MonoBehaviour
{

    //variables

    public static int contador;
    public static bool winning = false;

    public GameObject prize1;
    public GameObject prize2;
    public GameObject prize3;
    public GameObject prize4;
    public GameObject prize5;
    public GameObject panel1;
    public GameObject panel2;

    public GameObject prize1Col1;
    public GameObject prize2Col1;
    public GameObject prize3Col1;
    public GameObject prize4Col1;
    public GameObject prize5Col1;

    public GameObject prize1Col2;
    public GameObject prize2Col2;
    public GameObject prize3Col2;
    public GameObject prize4Col2;
    public GameObject prize5Col2;

    public GameObject prize1Col3;
    public GameObject prize2Col3;
    public GameObject prize3Col3;
    public GameObject prize4Col3;
    public GameObject prize5Col3;

    public GameObject prize1Col4;
    public GameObject prize2Col4;
    public GameObject prize3Col4;
    public GameObject prize4Col4;
    public GameObject prize5Col4;

    public GameObject prize1Col5;
    public GameObject prize2Col5;
    public GameObject prize3Col5;
    public GameObject prize4Col5;
    public GameObject prize5Col5;

    public GameObject WinWarning;

    public int ContadorColumna1 = 0;
    public int ContadorColumna2 = 0;
    public int ContadorColumna3 = 0;
    public int ContadorColumna4 = 0;
    public int ContadorColumna5 = 0;

    public TMP_Text avisoGanar;

    // Actualiza constantemente hasta llegar a 20 objetivos destruidos, cambia el color y el texto
    void Update()
    {
        contador = DestruirObjetivo.contador;

        if(contador >= 4){
            
            prize1.SetActive(true);

        }
        if(contador >= 8){
            
            prize2.SetActive(true);

        }
        if(contador >= 12){
            
            prize3.SetActive(true);

        }
        if(contador >= 16){
            
            prize4.SetActive(true);

        }
        if(contador >= 20){
            
            prize5.SetActive(true);
            avisoGanar.color = Color.yellow;
            avisoGanar.text = "¡Ve y abre el cofre!";

        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "chest"){

            if(contador>=20){
                winning = true;

                panel1.SetActive(false);
                panel2.SetActive(true);
            }

        }
    }

    public void ChangeColumna1(){

        if(ContadorColumna1==5){
            ContadorColumna1=0;
        }

        // cambiar opcion de la columna
        switch(ContadorColumna1){

            case 0: 
            
            prize1Col1.SetActive(true);
            prize2Col1.SetActive(false);
            prize3Col1.SetActive(false);
            prize4Col1.SetActive(false);
            prize5Col1.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 1: 
            
            prize1Col1.SetActive(false);
            prize2Col1.SetActive(true);
            prize3Col1.SetActive(false);
            prize4Col1.SetActive(false);
            prize5Col1.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 2: 
            
            prize1Col1.SetActive(false);
            prize2Col1.SetActive(false);
            prize3Col1.SetActive(true);
            prize4Col1.SetActive(false);
            prize5Col1.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 3: 
            
            prize1Col1.SetActive(false);
            prize2Col1.SetActive(false);
            prize3Col1.SetActive(false);
            prize4Col1.SetActive(true);
            prize5Col1.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 4: 
            
            prize1Col1.SetActive(false);
            prize2Col1.SetActive(false);
            prize3Col1.SetActive(false);
            prize4Col1.SetActive(false);
            prize5Col1.SetActive(true);
            Debug.Log("col1 " + ContadorColumna1);

            break;
            
        }

        ContadorColumna1++;

    }

    public void ChangeColumna2(){

        if(ContadorColumna2==5){
            ContadorColumna2=0;
        }

        // cambiar opcion de la columna
        switch(ContadorColumna2){

            case 0: 
            
            prize1Col2.SetActive(true);
            prize2Col2.SetActive(false);
            prize3Col2.SetActive(false);
            prize4Col2.SetActive(false);
            prize5Col2.SetActive(false);
            Debug.Log("col2 " + ContadorColumna2);

            break;

            case 1: 
            
            prize1Col2.SetActive(false);
            prize2Col2.SetActive(true);
            prize3Col2.SetActive(false);
            prize4Col2.SetActive(false);
            prize5Col2.SetActive(false);
            Debug.Log("col2 " + ContadorColumna2);

            break;

            case 2: 
            
            prize1Col2.SetActive(false);
            prize2Col2.SetActive(false);
            prize3Col2.SetActive(true);
            prize4Col2.SetActive(false);
            prize5Col2.SetActive(false);
            Debug.Log("col2 " + ContadorColumna2);

            break;

            case 3: 
            
            prize1Col2.SetActive(false);
            prize2Col2.SetActive(false);
            prize3Col2.SetActive(false);
            prize4Col2.SetActive(true);
            prize5Col2.SetActive(false);
            Debug.Log("col2 " + ContadorColumna2);

            break;

            case 4: 
            
            prize1Col2.SetActive(false);
            prize2Col2.SetActive(false);
            prize3Col2.SetActive(false);
            prize4Col2.SetActive(false);
            prize5Col2.SetActive(true);
            Debug.Log("col2 " + ContadorColumna2);

            break;
            
        }

        ContadorColumna2++;

    }

    public void ChangeColumna3(){

        if(ContadorColumna3==5){
            ContadorColumna3=0;
        }

        // cambiar opcion de la columna
        switch(ContadorColumna3){

            case 0: 
            
            prize1Col3.SetActive(true);
            prize2Col3.SetActive(false);
            prize3Col3.SetActive(false);
            prize4Col3.SetActive(false);
            prize5Col3.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 1: 
            
            prize1Col3.SetActive(false);
            prize2Col3.SetActive(true);
            prize3Col3.SetActive(false);
            prize4Col3.SetActive(false);
            prize5Col3.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 2: 
            
            prize1Col3.SetActive(false);
            prize2Col3.SetActive(false);
            prize3Col3.SetActive(true);
            prize4Col3.SetActive(false);
            prize5Col3.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 3: 
            
            prize1Col3.SetActive(false);
            prize2Col3.SetActive(false);
            prize3Col3.SetActive(false);
            prize4Col3.SetActive(true);
            prize5Col3.SetActive(false);
            Debug.Log("col1 " + ContadorColumna1);

            break;

            case 4: 
            
            prize1Col3.SetActive(false);
            prize2Col3.SetActive(false);
            prize3Col3.SetActive(false);
            prize4Col3.SetActive(false);
            prize5Col3.SetActive(true);
            Debug.Log("col1 " + ContadorColumna1);

            break;
            
        }

        ContadorColumna3++;

    }

    public void ChangeColumna4(){

        if(ContadorColumna4==5){
            ContadorColumna4=0;
        }

        // cambiar opcion de la columna
        switch(ContadorColumna4){

            case 0: 
            
            prize1Col4.SetActive(true);
            prize2Col4.SetActive(false);
            prize3Col4.SetActive(false);
            prize4Col4.SetActive(false);
            prize5Col4.SetActive(false);
            Debug.Log("col4 " + ContadorColumna4);

            break;

            case 1: 
            
            prize1Col4.SetActive(false);
            prize2Col4.SetActive(true);
            prize3Col4.SetActive(false);
            prize4Col4.SetActive(false);
            prize5Col4.SetActive(false);
            Debug.Log("col4 " + ContadorColumna4);

            break;

            case 2: 
            
            prize1Col4.SetActive(false);
            prize2Col4.SetActive(false);
            prize3Col4.SetActive(true);
            prize4Col4.SetActive(false);
            prize5Col4.SetActive(false);
            Debug.Log("col4 " + ContadorColumna4);

            break;

            case 3: 
            
            prize1Col4.SetActive(false);
            prize2Col4.SetActive(false);
            prize3Col4.SetActive(false);
            prize4Col4.SetActive(true);
            prize5Col4.SetActive(false);
            Debug.Log("col4 " + ContadorColumna4);

            break;

            case 4: 
            
            prize1Col4.SetActive(false);
            prize2Col4.SetActive(false);
            prize3Col4.SetActive(false);
            prize4Col4.SetActive(false);
            prize5Col4.SetActive(true);
            Debug.Log("col4 " + ContadorColumna4);

            break;
            
        }

        ContadorColumna4++;

    }

    public void ChangeColumna5(){

        if(ContadorColumna5==5){
            ContadorColumna5=0;
        }

        // cambiar opcion de la columna
        switch(ContadorColumna5){

            case 0: 
            
            prize1Col5.SetActive(true);
            prize2Col5.SetActive(false);
            prize3Col5.SetActive(false);
            prize4Col5.SetActive(false);
            prize5Col5.SetActive(false);
            Debug.Log("col5 " + ContadorColumna5);

            break;

            case 1: 
            
            prize1Col5.SetActive(false);
            prize2Col5.SetActive(true);
            prize3Col5.SetActive(false);
            prize4Col5.SetActive(false);
            prize5Col5.SetActive(false);
            Debug.Log("col5 " + ContadorColumna5);

            break;

            case 2: 
            
            prize1Col5.SetActive(false);
            prize2Col5.SetActive(false);
            prize3Col5.SetActive(true);
            prize4Col5.SetActive(false);
            prize5Col5.SetActive(false);
            Debug.Log("col5 " + ContadorColumna5);

            break;

            case 3: 
            
            prize1Col5.SetActive(false);
            prize2Col5.SetActive(false);
            prize3Col5.SetActive(false);
            prize4Col5.SetActive(true);
            prize5Col5.SetActive(false);
            Debug.Log("col5 " + ContadorColumna5);

            break;

            case 4: 
            
            prize1Col5.SetActive(false);
            prize2Col5.SetActive(false);
            prize3Col5.SetActive(false);
            prize4Col5.SetActive(false);
            prize5Col5.SetActive(true);
            Debug.Log("col5 " + ContadorColumna5);

            break;
            
        }

        ContadorColumna5++;

    }

    public void TryWin(){

        if((ContadorColumna1+1 == 2) && (ContadorColumna2+1 == 5) && (ContadorColumna3+1 == 1) && (ContadorColumna4+1 == 4) && (ContadorColumna5+1 == 3)){

            SceneManager.LoadScene("Win");
            
        }else{

            WinWarning.SetActive(true);

        }

    }
}
