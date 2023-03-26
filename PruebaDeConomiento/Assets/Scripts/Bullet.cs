using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    public float lifeduration = 2f;
    private float lifetimer;

    // Start is called before the first frame update
    void Start()
    {
        lifetimer = lifeduration;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifetimer -= Time.deltaTime;
        if(lifetimer <= 0f){
            Destroy(gameObject);
        }
    }
    
}
