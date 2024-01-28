using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static ActionCard;

public class ActionSlot : MonoBehaviour
{

    public int id;

    [SerializeField] TextMeshProUGUI nameCard;

    [SerializeField] TextMeshProUGUI points;

    [SerializeField] TextMeshProUGUI description;

    [SerializeField] Image sprite;

    [SerializeField] Image Card;

    [SerializeField] Category categorie;

    [SerializeField] ActionCard actionCard;

    public void Start()
    {
        AbilitieManager.instance.OnAbilitieChanged += ChangeAbilitie;
    }

    public void ChangeAbilitie(int id, ActionCard actionCard)
    {
        if (id == this.id)
        {
            Debug.Log("Abilitie Changed");
            nameCard.text = actionCard.actionName;
            points.text = actionCard.points.ToString();
            description.text = actionCard.description;
            Card.sprite = actionCard.card;
            sprite.sprite = actionCard.sprite;
            categorie = actionCard.category;
            this.actionCard = actionCard;
        }
    }

    public void PerformAction()
    {
        if (this.actionCard != null)
        {
            AbilitieManager.instance.AbilitieUsed(actionCard);

            GameManager.instance.accumulatedPoints += actionCard.points;
            GameManager.instance.ActualizePoints();
        }
    }

}
