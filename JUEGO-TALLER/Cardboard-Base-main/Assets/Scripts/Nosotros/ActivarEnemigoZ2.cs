using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarEnemigoZ2 : MonoBehaviour
{

    private GameObject enemigo1;
    private GameObject enemigo2;
    private GameObject enemigo3;
    private GameObject enemigo4;
    int state = 0;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        enemigo1 = GameObject.Find("Enemigo_1");
        enemigo2 = GameObject.Find("Enemigo_2");
        enemigo3 = GameObject.Find("Enemigo_3");
        enemigo4 = GameObject.Find("Enemigo_4");
        enemigo4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(state == 1)
        {
            Destroy(enemigo1);
            Destroy(enemigo2);
            Destroy(enemigo3);
        }
        else if(state == 2)
        {
            t += Time.deltaTime;
            if(t >= 10)
            {
                enemigo4.SetActive(true);
                state = 3;
            }
            

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
