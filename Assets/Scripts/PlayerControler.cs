using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float[] posicionesX = { -2f, 0f, 2f };
    private int indicePosicion;

    void Start()
    {
        indicePosicion = Random.Range(0, 3);
        transform.position = new Vector3(posicionesX[indicePosicion], 0.5f, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (indicePosicion > 0)
            {
                indicePosicion--;
                transform.position = new Vector3(posicionesX[indicePosicion], 0.5f, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (indicePosicion < posicionesX.Length - 1)
            {
                indicePosicion++;
                transform.position = new Vector3(posicionesX[indicePosicion], 0.5f, 0);
            }
        }
    }
}