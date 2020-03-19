using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    Rigidbody2D nave;
    public GameObject bala;
    float movimiento;
    public float speed;
    public GameObject balaC;
    public static int vida;

    // Start is called before the first frame update
    void Start()
    {
        nave = gameObject.GetComponent<Rigidbody2D>();
        balaC = null;
        vida = 4;

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.color = new Color(0f, 1f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxis("Horizontal") * speed;
        nave.MovePosition(new Vector2(nave.position.x + movimiento, nave.position.y));
        if (Input.GetAxis("Jump") == 1.0 && balaC == null)
        {
            balaC = Instantiate(bala, new Vector3(nave.position.x, nave.position.y + 1, bala.transform.position.z), new Quaternion(0,0,0,0));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BalaE")
        {
            vida--;
            if (vida == 3)
            {
                SpriteRenderer renderer = GetComponent<SpriteRenderer>();
                renderer.color = new Color(0, 1, 1, 1);
            }
            if (vida == 2)
            {
                SpriteRenderer renderer = GetComponent<SpriteRenderer>();
                renderer.color = new Color(1, 0.92f, 0.016f, 1); 
            }
            if (vida == 1)
            {
                SpriteRenderer renderer = GetComponent<SpriteRenderer>();
                renderer.color = new Color(1, 0, 0, 1);
            }
            if (vida == 0)
            {
                Destroy(gameObject);
                Time.timeScale = 0;
            }
                
        }
            
    }
}

