using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Yes ()
    {
        Debug.Log("quiting the Game...");
        Application.Quit ();
    }

    public void No ()
    {
        SceneManager.LoadScene("Menu");
    }
}
