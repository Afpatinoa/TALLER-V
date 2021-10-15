using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoJefe : MonoBehaviour
{
    new AudioSource audio;
    float t = 0;
    float periodo = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (t >= periodo)
        {
            audio.volume = Random.Range(0.8f, 1f);
            audio.pitch = Random.Range(0.8f, 1f);
            audio.Play();
            t = 0;
            periodo = Random.Range(6f,10f );
        }
        t += Time.deltaTime;
    }
}
