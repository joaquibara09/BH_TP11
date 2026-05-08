using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColissionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Colision con " + col.gameObject.name);
        if(col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
        } else if(col.gameObject.CompareTag("Piso"))
        {
            Destroy(gameObject);
        }
    }
}
