using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //UI
    [SerializeField] public int RoundNumber;
    [SerializeField] public int accumulatedPoints;

    public Action<List<ActionCard>> OnIntermission;

    public Action<int> OnRoundStart;

    public List<ActionCard> Cards = new List<ActionCard>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

        switch (RoundNumber)
        {
            case 1:
                if (OnIntermission != null) OnIntermission(Selectedcards(3));
                break;
            case 2:
                if (OnIntermission != null) OnIntermission(Selectedcards(4));
                break;
            case 3:
                if (OnIntermission != null) OnIntermission(Selectedcards(5));
                break;
        }
        
        if (RoundNumber < 3) RoundNumber++;
    }

    private List<ActionCard> Selectedcards(int cards)
    {
        List<ActionCard> choosenCards = new List<ActionCard>();

        ActionCard lastRandomCard;

        for (int i = 0; i < cards; i++)
        {
            ActionCard randomCard = Cards[UnityEngine.Random.Range(0, Cards.Count)];

            if (lastRandomCard = null)
            {
                choosenCards.Add(randomCard);
            }
            else if (lastRandomCard != randomCard)
            {
                choosenCards.Add(randomCard);
            }
            else
            {
                randomCard = Cards[UnityEngine.Random.Range(0, Cards.Count)];
            }

            lastRandomCard = randomCard;

        }

        return choosenCards;
    }

    public void StartRound(int i)
    {
        if (OnRoundStart != null) OnRoundStart(i);
    }
    
    
}


