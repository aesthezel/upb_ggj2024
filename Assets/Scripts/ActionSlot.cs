using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static ActionCard;

public class ActionSlot : MonoBehaviour
{

    public int id;

    [SerializeField] Text nameCard;

    [SerializeField] Text points;

    [SerializeField] Sprite sprite;

    [SerializeField] Categories categorie;

    [SerializeField] ActionCard actionCard;

    public void Start()
    {
        AbilitieManager.instance.OnAbilitieChanged += ChangeAbilitie;
    }

    public void ChangeAbilitie(int id, ActionCard actionCard)
    {
        if (id == this.id)
        {
            nameCard.text = actionCard.actionName;
            points.text = actionCard.points.ToString();
            sprite = actionCard.sprite;
            categorie = actionCard.category;
            this.actionCard = actionCard;
        }
        

    }

}
