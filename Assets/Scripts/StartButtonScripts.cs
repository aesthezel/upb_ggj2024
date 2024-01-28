using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScripts : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Has salido de app");
    }

    public void Credits()
    {
        SceneManager.LoadScene(3);
    }



}
