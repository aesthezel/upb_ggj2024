using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumberPicker : MonoBehaviour
{
    [SerializeField] private string CardA;
    [SerializeField] private string CardB;
    [SerializeField] private string CardC;

    public TextMeshProUGUI CardAText;
    public TextMeshProUGUI CardBText;
    public TextMeshProUGUI CardCText;




    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        int RandomNumberChosenA = 0;
        int RandomNumberChosenB = 0;
        int RandomNumberChosenC = 0;

        RandomNumberChosenA = rnd.Next(1,11);
        RandomNumberChosenB = rnd.Next(1, 11);
        RandomNumberChosenC = rnd.Next(1, 11);

        Debug.Log("numero fue A " + RandomNumberChosenA);
        Debug.Log("numero fue B " + RandomNumberChosenB);
        Debug.Log("numero fue C " + RandomNumberChosenC);

        if (RandomNumberChosenA == 1) { CardA = "Pollificacion"; }
        if (RandomNumberChosenB == 1) { CardB = "Pollificacion"; }
        if (RandomNumberChosenC == 1) { CardC = "Pollificacion"; }

        if (RandomNumberChosenA == 2) { CardA = "Alt F4"; }
        if (RandomNumberChosenB == 2) { CardB = "Alt F4"; }
        if (RandomNumberChosenC == 2) { CardC = "Alt F4"; }

        if (RandomNumberChosenA == 3) { CardA = "Lluvia Pesada"; }
        if (RandomNumberChosenB == 3) { CardB = "Lluvia Pesada"; }
        if (RandomNumberChosenC == 3) { CardC = "Lluvia Pesada"; }

        if (RandomNumberChosenA == 4) { CardA = "Vuelta SuperMegaHiperUltraEpica"; }
        if (RandomNumberChosenB == 4) { CardB = "Vuelta SuperMegaHiperUltraEpica"; }
        if (RandomNumberChosenC == 4) { CardC = "Vuelta SuperMegaHiperUltraEpica"; }

        if (RandomNumberChosenA == 5) { CardA = "Encanado"; }
        if (RandomNumberChosenB == 5) { CardB = "Encanado"; }
        if (RandomNumberChosenC == 5) { CardC = "Encanado"; }

        if (RandomNumberChosenA == 6) { CardA = "Me huele la axila"; }
        if (RandomNumberChosenB == 6) { CardB = "Me huele la axila"; }
        if (RandomNumberChosenC == 6) { CardC = "Me huele la axila"; }

        if (RandomNumberChosenA == 7) { CardA = "La llamada"; }
        if (RandomNumberChosenB == 7) { CardB = "La llamada"; }
        if (RandomNumberChosenC == 7) { CardC = "La llamada"; }

        if (RandomNumberChosenA == 8) { CardA = "Oh no :("; }
        if (RandomNumberChosenB == 8) { CardB = "Oh no :("; }
        if (RandomNumberChosenC == 8) { CardC = "Oh no :("; }

        if (RandomNumberChosenA == 9) { CardA = "Comodin"; }
        if (RandomNumberChosenB == 9) { CardB = "Comodin"; }
        if (RandomNumberChosenC == 9) { CardC = "Comodin"; }

        if (RandomNumberChosenA == 10) { CardA = "Pasta de Tomate"; }
        if (RandomNumberChosenB == 10) { CardB = "Pasta de Tomate"; }
        if (RandomNumberChosenC == 10) { CardC = "Pasta de Tomate"; }


        Debug.Log("Carta A " + CardA);
        Debug.Log("Carta B " + CardB);
        Debug.Log("Carta C " + CardC);

        CardAText.SetText(CardA);
        CardBText.SetText(CardB);
        CardCText.SetText(CardC);



    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
