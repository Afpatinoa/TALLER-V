using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarZF : MonoBehaviour
{
    private GameObject enemigo4;
    private GameObject jefe;
    int state = 0;


    void Start()
    {
        enemigo4 = GameObject.Find("Enemigo_4");
        jefe = GameObject.Find("Jefe");
        jefe.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(state == 1)
        {
            Destroy(enemigo4);

        }
        else if(state == 2)
        {
            jefe.SetActive(true);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (state == 0 && other.CompareTag("Player"))
        {
            state = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            state = 2;
        }
    }
}
