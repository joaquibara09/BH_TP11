using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColissionDetection : MonoBehaviour
{
    private float[] posicionesX = { -2f, 0f, 2f };

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            UIManager.instancia.MostrarGameOver();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("Piso"))
        {
            ReSpawnCaja();
        }
    }

    void ReSpawnCaja()
    {
        float nuevaX = posicionesX[Random.Range(0, posicionesX.Length)];
        transform.position = new Vector3(nuevaX, 8f, 0);

        GetComponent<CajaMovement>().enabled = false;
        GetComponent<CajaMovement>().enabled = true;
    }
}