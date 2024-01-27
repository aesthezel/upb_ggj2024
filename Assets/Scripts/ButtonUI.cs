using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    //Funcion para cada boton

    public bool IsCardLive = false;
    public bool Hop = true;

    public GameObject CardToShowA;
    public GameObject CardToShowB;
    public GameObject CardToShowC;
    public GameObject CardToShowD;
    public GameObject CardToShowE;

    public void Q()
    {
        Debug.Log("Presionaste la Q");

 //       CardToShowA = 

        if (IsCardLive == true & Hop == false)
        {
            IsCardLive = false;
            CardToShowA.SetActive(false);
            Hop = true;
        }

        if (IsCardLive == false & Hop == false)
        {

            Debug.Log("Carta Armada");
            CardToShowA.SetActive(true);
            IsCardLive = true;
        }

        Hop = false;
    }

    public void W()
    {
        Debug.Log("Presionaste la W");

        if (IsCardLive == true & Hop == false)
        {
            IsCardLive = false;
            CardToShowB.SetActive(false);
            Hop = true;
        }

        if (IsCardLive == false & Hop == false)
        {

            Debug.Log("Carta Armada");
            CardToShowB.SetActive(true);
            IsCardLive = true;
        }

        Hop = false;
    }

    public void E()
    {
        Debug.Log("Presionaste la E");

        if (IsCardLive == true & Hop == false)
        {
            IsCardLive = false;
            CardToShowC.SetActive(false);
            Hop = true;
        }

        if (IsCardLive == false & Hop == false)
        {

            Debug.Log("Carta Armada");
            CardToShowC.SetActive(true);
            IsCardLive = true;
        }

        Hop = false;
    }

    public void R()
    {
        Debug.Log("Presionaste la R");

        if (IsCardLive == true & Hop == false)
        {
            IsCardLive = false;
            CardToShowD.SetActive(false);
            Hop = true;
        }

        if (IsCardLive == false & Hop == false)
        {

            Debug.Log("Carta Armada");
            CardToShowD.SetActive(true);
            IsCardLive = true;
        }

        Hop = false;
    }

    public void T()
    {
        Debug.Log("Presionaste la T");

        if (IsCardLive == true & Hop == false)
        {
            IsCardLive = false;
            CardToShowE.SetActive(false);
            Hop = true;
        }

        if (IsCardLive == false & Hop == false)
        {

            Debug.Log("Carta Armada");
            CardToShowE.SetActive(true);
            IsCardLive = true;
        }

        Hop = false;
    }

    public void Back()
    {
        CardToShowA.SetActive(false);
    }




    





}

//Doble bool para ver si la carta esta y si esta apagarla

