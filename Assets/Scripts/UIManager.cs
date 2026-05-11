using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instancia;
    public TextMeshProUGUI textoUI;

    private float tiempoTranscurrido;
    private bool juegoTerminado = false;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        tiempoTranscurrido = 0f;
        textoUI.text = "Tiempo: 0s";
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            tiempoTranscurrido += Time.deltaTime;
            textoUI.text = "Tiempo: " + Mathf.FloorToInt(tiempoTranscurrido) + "s";
        }
    }

    public void MostrarGameOver()
    {
        juegoTerminado = true;
        textoUI.text = "Perdiste!";
        Time.timeScale = 0f;
    }
}