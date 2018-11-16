using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseCanvas;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PauseCanvas.SetActive(true);
        }

    }
    public void Resume()
    {
        //Debug.Log("Resume");
        PauseCanvas.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
