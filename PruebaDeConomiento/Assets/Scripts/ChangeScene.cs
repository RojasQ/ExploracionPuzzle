using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    
    public void ChangeMyscene(string name){
        
        SceneManager.LoadScene(name);
    }
}
