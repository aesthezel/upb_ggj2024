using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitieManager : MonoBehaviour
{
    public static AbilitieManager instance;

    public Action<int, ActionCard> OnAbilitieChanged;

    public void AssignAbilitie(ActionCard actionCard, Action abilitie, int abilitieNumber)
    {
        switch (abilitieNumber)
        {
            case 1:
                AbilitieChanged(1, actionCard);
                break;
            case 2:
                AbilitieChanged(2, actionCard);
                break;
            case 3:
                AbilitieChanged(3, actionCard);
                break;
            case 4:
                AbilitieChanged(4, actionCard);
                break;
            case 5:
                AbilitieChanged(5, actionCard);
                break;
        }
    }

    public void AbilitieChanged(int id, ActionCard actionCard)
    {
        if (OnAbilitieChanged != null) OnAbilitieChanged(id, actionCard);
    }

}
