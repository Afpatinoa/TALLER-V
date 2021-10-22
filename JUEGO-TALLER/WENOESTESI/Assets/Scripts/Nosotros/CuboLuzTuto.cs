using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboLuzTuto : MonoBehaviour
{
    // Start is called before the first frame update
    Luz luz;
    void awake()
    {
        luz = GetComponentInChildren<Luz>();
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            

        }
    }
}
