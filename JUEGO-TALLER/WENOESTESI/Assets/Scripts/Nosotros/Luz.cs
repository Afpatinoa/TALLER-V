using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    CuboLuzTuto cubo;
    Renderer renderer;

    void Awake()
    {
        cubo = GetComponentInParent<CuboLuzTuto>();
        renderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            renderer.material.color = color.white;
        }
    }
}
