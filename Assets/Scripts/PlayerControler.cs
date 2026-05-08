using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2,0,0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2,0,0);
        }
    }
}
