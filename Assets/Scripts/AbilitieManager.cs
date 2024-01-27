using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitieManager : MonoBehaviour
{
    private Action abilitie1, abilitie2, abilitie3, abilitie4, abilitie5;

    [SerializeField] private ActionCard actionCard1, actionCard2, actionCard3, actionCard4, actionCard5;

    public void AssignAbilitie(ActionCard actionCard, Action abilitie, int abilitieNumber)
    {
        switch (abilitieNumber)
        {
            case 1:
                abilitie1 = abilitie;
                actionCard1 = actionCard;
                break;
            case 2:
                abilitie2 = abilitie;
                actionCard2 = actionCard;
                break;
            case 3:
                abilitie3 = abilitie;
                actionCard3 = actionCard;
                break;
            case 4:
                abilitie4 = abilitie;
                actionCard4 = actionCard;
                break;
            case 5:
                abilitie5 = abilitie;
                actionCard5 = actionCard;
                break;
        }
    }

    public void OnAbilitie1()
    {
        if (abilitie1 != null) { abilitie1(); }
    }
    public void OnAbilitie2()
    {
        if (abilitie1 != null) { abilitie2(); }
    }
    public void OnAbilitie3()
    {
        if (abilitie1 != null) { abilitie3(); }
    }
    public void OnAbilitie4()
    {
        if (abilitie1 != null) { abilitie4(); }
    }
    public void OnAbilitie5()
    {
        if (abilitie1 != null) { abilitie5(); }
    }

}
