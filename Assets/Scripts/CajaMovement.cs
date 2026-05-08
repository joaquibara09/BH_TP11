using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        transform.Translate(0,-speed * Time.deltaTime,0);
    }
}
