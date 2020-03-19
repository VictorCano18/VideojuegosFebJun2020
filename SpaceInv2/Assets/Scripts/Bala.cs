
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    //public int score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);
            //score += 10;
        }

        /*if(score == 10)
        {
            Debug.Log("Ganaste, tu puntacion es: " + score);
        }*/

        Destroy(gameObject);

    }
}