using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    Rigidbody2D rb;
    float limiteI, limiteD, posicionActual;
    private int contador;
    public int velocidad;
    public GameObject balaE;
    public int contadorD;
    public int disparo;
    private int contadorB;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        posicionActual = rb.position.x;
        limiteI = posicionActual - 1;
        limiteD = posicionActual + 1;
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
        contadorD++;
        contadorB++;

        if (contadorD == disparo)
        {
            Instantiate(balaE, new Vector3(rb.position.x, rb.position.y - 1), new Quaternion(0, 0, 0, 0));
            contadorD = 0;
        }

        if (posicionActual < limiteD && contador == velocidad)
        {
            posicionActual++;
            rb.position = new Vector3(posicionActual, rb.position.y);
            contador = 0;

            //Instantiate(balaE, new Vector3(rb.position.x, rb.position.y - 1, balaE.transform.position.z), new Quaternion(0, 0, 0, 0));
        }
        if (posicionActual == limiteD && contador == velocidad)
        {
            posicionActual = posicionActual - 2;
            rb.position = new Vector3(posicionActual, rb.position.y);
            contador = 0;
        }

        if (contadorB == 250)
        {
            rb.position = new Vector3(rb.position.x, rb.position.y - 1);
            contadorB = 0;
        }

        //rb.position = new Vector2(posicionActual, rb.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso")
        {
            Destroy(gameObject);
            Lose.loseText.enabled = true;
            Time.timeScale = 0;
            Restart.restart.enabled = true;
        }
        if(collision.gameObject.tag == "Bala")
        {
            Score.playerscore += 10;
            score += 10;
        }
        if (score == 60)
        {
            Debug.Log("Ganaste, tu puntacion es: " + score);
        }
    }
}