using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Soccer Ball")
        {
            Debug.Log("GOAL!");
        }
        else if (other.name == "Player")
        {
            Debug.Log("GET OUT OF THERE!");
        }
    }
}
