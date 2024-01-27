using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    //Funcion para cada boton

    public GameObject CardToShow;

    public void Q()
    {
        Debug.Log("Presionaste la Q");
        CardToShow.SetActive(true);
    }

    public void W()
    {
        Debug.Log("Presionaste la W");
    }

    public void E()
    {
        Debug.Log("Presionaste la E");
    }

    public void R()
    {
        Debug.Log("Presionaste la R");
    }

    public void T()
    {
        Debug.Log("Presionaste la T");
    }

    public void Back()
    {
        CardToShow.SetActive(false);
    }

}
