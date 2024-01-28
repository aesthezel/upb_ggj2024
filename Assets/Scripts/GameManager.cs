using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //UI
    [SerializeField] public int RoundNumber;
    [SerializeField] public int accumulatedPoints;
    [SerializeField] TextMeshProUGUI RoundUI;
    [SerializeField] TextMeshProUGUI PointsUI;

    public Action<int> OnIntermission;

    public Action<int> OnRoundStart;

    public List<ActionCard> Cards = new List<ActionCard>();

    public List<ActionCard> ChoseenCardsList = new List<ActionCard>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

        OnIntermission += Selectedcards;

        switch (RoundNumber)
        {
            case 1:
                UnityEngine.Debug.Log("Entro a intermision");
                if (OnIntermission != null) OnIntermission(3);
                Selectedcards(3);
                RoundUI.text = RoundNumber.ToString();
                break;
            case 2:
                if (OnIntermission != null) OnIntermission(4);
                break;
            case 3:
                if (OnIntermission != null) OnIntermission(5);
                break;
        }

        
        
        if (RoundNumber < 3) RoundNumber++;
    }

    private void Selectedcards(int cards)
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

        //----------------------------TEMPORAL PARA TESTEO-----------------------------------------------
        AddAbilities(choosenCards);
        //-----------------------------------------------------------------------------------------------
        ChoseenCardsList = choosenCards;

        UnityEngine.Debug.Log(choosenCards);
    }

    public void AddAbilities(List<ActionCard> actionCards)
    {
        for (int i = 0; i < actionCards.Count; i++)
        {
            AbilitieManager.instance.AssignAbilitie(actionCards[i], i);
        }
    }

    public void StartRound(int i)
    {
        if (OnRoundStart != null) OnRoundStart(i);
    }
    
    public void ActualizePoints()
    {
        PointsUI.text = accumulatedPoints.ToString(); 
    }
    
}


