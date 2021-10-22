using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarEnemigo : MonoBehaviour
{
    //GameObject enemigo = GameObject.Find("Enemigo_1");
    private GameObject enemigo1;
    private GameObject enemigo2;
    private GameObject enemigo3;
    private GameObject door;
    [SerializeField] AudioSource Zona1;
    [SerializeField] AudioSource Puerta;
    [SerializeField] Animator[] animator;
    int state = 0;
    void Start()
    {
        enemigo1 = GameObject.Find("Enemigo_1");
        enemigo1.SetActive(false);
        enemigo2 = GameObject.Find("Enemigo_2");
        enemigo2.SetActive(false);
        enemigo3 = GameObject.Find("Enemigo_3");
        enemigo3.SetActive(false);
        door = GameObject.Find("DoorAnimada1");

    }

    // Update is called once per frame
    void Update()
    {
        if(state == 1)
        {
            enemigo1.SetActive(true);
            enemigo2.SetActive(true);
            enemigo3.SetActive(true);
            Zona1.pitch = 1.5f;
            Animator doorAnimada1 = door.GetComponent<Animator>();
            doorAnimada1.SetTrigger("open");
            state = 2;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (state == 0 && other.CompareTag("Player"))
        {
            state = 1;
           
        }
    }

}
