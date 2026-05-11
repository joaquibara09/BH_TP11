using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CajaMovement : MonoBehaviour
{
    public float velocidadBase = 1f;
    public float exponente = 1.5f;
    private float tiempoInicio;

    void OnEnable()
    {
        tiempoInicio = Time.time;
    }

    void Update()
    {
        float tiempoTranscurrido = Time.time - tiempoInicio;
        float velocidadActual = velocidadBase * Mathf.Pow(tiempoTranscurrido + 1f, exponente);
        transform.Translate(0, -velocidadActual * Time.deltaTime, 0);
    }
}