using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AbilitieManager : MonoBehaviour
{
    public static AbilitieManager instance;

    public UnityEvent<ActionCardBundle[]> OnAbilitiesBundleChanged;
    public Action<int, ActionCard> OnAbilitieChanged;

    public Action<ActionCard> OnActionPerformAnim, OnActionPerformSpawn, OnActionPerformRagdoll;

    public GameObject Player;

    private void Awake()
    {
        instance = this;
    }

    // DEPRECATED
    // public void AssignAbilitie(ActionCard actionCard, int abilitieNumber)
    // {
    //     switch (abilitieNumber)
    //     {
    //         case 1:
    //             AbilitieChanged(1, actionCard);
    //             break;
    //         case 2:
    //             AbilitieChanged(2, actionCard);
    //             break;
    //         case 3:
    //             AbilitieChanged(3, actionCard);
    //             break;
    //         case 4:
    //             AbilitieChanged(4, actionCard);
    //             break;
    //         case 5:
    //             AbilitieChanged(5, actionCard);
    //             break;
    //     }
    // }
    
    // DEPRECATED
    // public void AbilitieChanged(int id, ActionCard actionCard)
    // { 
    //     OnAbilitieChanged?.Invoke(id, actionCard);
    // }

    public void AddAbilities(IEnumerable<ActionCard> cards)
    {
        var bundle = new List<ActionCardBundle>();
        var counterID = 1;
        
        foreach (var actionCard in cards)
        {
            bundle.Add(new ActionCardBundle()
            {
                Id = counterID,
                Card = actionCard
            });

            counterID++;
        }
        
        Debug.Log($"Configurado el bundle! {bundle.Count}");
        
        AbilitiesChanged(bundle.ToArray());
    }
    private void AbilitiesChanged(ActionCardBundle[] bundle)
    {
        OnAbilitiesBundleChanged?.Invoke(bundle);
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

[Serializable]
public struct ActionCardBundle
{
    public int Id;
    public ActionCard Card;
}