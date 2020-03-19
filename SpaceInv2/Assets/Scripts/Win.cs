using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour
{
    private Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText = GetComponent<Text>();
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.playerscore == 60)
        {
            winText.enabled = true;
            winText.text = "¡Ganaste! \n tu score es: " + Score.playerscore;
        }
            

    }
}
