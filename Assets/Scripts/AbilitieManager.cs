using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitieManager : MonoBehaviour
{
    public static AbilitieManager instance;

    public Action<int, ActionCard> OnAbilitieChanged;

    public Action<ActionCard> OnActionPerformAnim, OnActionPerformSpawn, OnActionPerformRagdoll;

    public GameObject Player;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        GameManager.instance.OnNewAbilitie += AssignAbilitie;
    }

    public void AssignAbilitie(int abilitieNumber, ActionCard actionCard)
    {

        Debug.Log("Entro assign Abilitie");

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
        Debug.Log("Entro a abilitie changed");
        if (OnAbilitieChanged != null) OnAbilitieChanged.Invoke(id, actionCard);
    }

    public void AbilitieUsed(ActionCard actionCard)
    {
        switch (actionCard.cardType) {
            case ActionCard.CardType.animation:
                Debug.Log("Entro");
                if (OnActionPerformAnim != null) OnActionPerformAnim(actionCard);
                break;
            case ActionCard.CardType.spawner: 
                if (OnActionPerformSpawn != null) OnActionPerformSpawn(actionCard);
                break;
            case ActionCard.CardType.ragdoll:
                if (OnActionPerformRagdoll!= null) OnActionPerformRagdoll(actionCard);
                break;

        }
    }


}
