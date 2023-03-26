using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera playercamera;
    public GameObject bulletPrefab;
    public AudioSource piu;

    // Reproduce el sonido al disparar presionando el mouse
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject bulletObject = Instantiate (bulletPrefab);
            bulletObject.transform.position = playercamera.transform.position + playercamera.transform.forward;
            bulletObject.transform.forward = playercamera.transform.forward;
            piu.Play();
        }
    }
}
