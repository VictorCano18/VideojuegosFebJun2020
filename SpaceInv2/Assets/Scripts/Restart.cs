using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public static Text restart;
    private void Start()
    {
        restart = GetComponent<Text>();
        restart.enabled = false;
    }


    // Update is called once per frame
    public void Update()
    {
        if(Nave.vida == 0)
        {
            restart.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Score.playerscore = 0;
            Time.timeScale = 1;

            SceneManager.LoadScene("SampleScene");
        }
    }
}
