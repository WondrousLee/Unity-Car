using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public void carGame()
    {
        SceneManager.LoadScene("Challenge 1");
    }

    public void planeGame()
    {
        SceneManager.LoadScene("Prototype 1");
    }
}
