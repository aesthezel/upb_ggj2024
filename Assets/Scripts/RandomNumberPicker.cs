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

    [SerializeField] private Sprite CardASP;
    [SerializeField] private Sprite CardBSP;
    [SerializeField] private Sprite CardCSP;

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

        RandomNumberChosenA = rnd.Next(1,9);
        RandomNumberChosenB = rnd.Next(1, 9);
        RandomNumberChosenC = rnd.Next(1, 9);

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

        if (RandomNumberChosenA == 5) { CardA = "Me huele la axila"; }
        if (RandomNumberChosenB == 5) { CardB = "Me huele la axila"; }
        if (RandomNumberChosenC == 5) { CardC = "Me huele la axila"; }

        if (RandomNumberChosenA == 6) { CardA = "La llamada"; }
        if (RandomNumberChosenB == 6) { CardB = "La llamada"; }
        if (RandomNumberChosenC == 6) { CardC = "La llamada"; }

        if (RandomNumberChosenA == 7) { CardA = "Oh no :("; }
        if (RandomNumberChosenB == 7) { CardB = "Oh no :("; }
        if (RandomNumberChosenC == 7) { CardC = "Oh no :("; }

        if (RandomNumberChosenA == 8) { CardA = "Pasta de Tomate"; }
        if (RandomNumberChosenB == 8) { CardB = "Pasta de Tomate"; }
        if (RandomNumberChosenC == 8) { CardC = "Pasta de Tomate"; }


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
