using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionSlot : MonoBehaviour
{
    public int id;
    [SerializeField] TextMeshProUGUI nameCard;
    [SerializeField] TextMeshProUGUI points;
    [SerializeField] TextMeshProUGUI description;
    [SerializeField] private TMP_Text nameCardDisplay;
    [SerializeField] Image sprite;
    [SerializeField] Category category;
    [SerializeField] ActionCard actionCard;
    private bool _isPerformed;

    public void ChangeAbility(int id, ActionCard actionCard)
    {
        if (id != this.id) return;
        _isPerformed = false;
        this.actionCard = actionCard;
        nameCardDisplay.text = this.actionCard.name;
        nameCard.text = actionCard.actionName;
        points.text = actionCard.points.ToString();
        description.text = actionCard.description;
        sprite.sprite = actionCard.sprite;
        category = actionCard.category;
    }

    public void PerformAction()
    {
        if (_isPerformed) return;
        if (actionCard == null) return;
        
        _isPerformed = true;
        AbilitieManager.instance.AbilitieUsed(actionCard);
        GameManager.instance.accumulatedPoints += actionCard.points;
        GameManager.instance.ActualizePoints();
    }

}
