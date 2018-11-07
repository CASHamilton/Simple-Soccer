

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Field 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}


