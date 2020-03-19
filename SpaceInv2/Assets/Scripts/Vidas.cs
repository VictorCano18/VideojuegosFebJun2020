using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    private Text vidaText;
    // Start is called before the first frame update
    void Start()
    {
        vidaText = GetComponent<Text>();
        vidaText.enabled = true;
        vidaText.text = "Vidas: " + 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Nave.vida == 3)
            vidaText.text = "Vidas: " + 3;
        if (Nave.vida == 2)
            vidaText.text = "Vidas: " + 2;
        if (Nave.vida == 1)
            vidaText.text = "Vidas: " + 1;
        if (Nave.vida == 0)
            vidaText.text = "Vidas: " + 0;



    }
}
