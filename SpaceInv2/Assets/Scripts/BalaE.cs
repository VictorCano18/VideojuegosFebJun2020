using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaE : MonoBehaviour
{
    private void Update()
    {
        if(Nave.vida == 0)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso" || collision.gameObject.tag == "Nave")
            Destroy(gameObject);

        Destroy(gameObject);

    }
}