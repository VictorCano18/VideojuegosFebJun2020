using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    public static Text loseText;
    // Start is called before the first frame update
    void Start()
    {
        loseText = GetComponent<Text>();
        loseText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Nave.vida == 0)
            loseText.enabled = true;
    }
}
