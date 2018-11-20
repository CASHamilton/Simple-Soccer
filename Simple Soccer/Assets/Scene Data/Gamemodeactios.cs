using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemodeactios : MonoBehaviour
{
    public void Regular()
    {
        SceneManager.LoadScene("Field 1");
    }
    public void Motorball()
    {
        SceneManager.LoadScene("Motorball");
    }



}
