using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class JudgeRuntime : MonoBehaviour
{
    public Judge JudgeSO;
    public TMP_Text NameText;
    public TMP_Text PointText;

    private void Start()
    {
        NameText.text = JudgeSO.judgeName;
        NameText.color = JudgeSO.baseCategory.color;
    }

    public int EvaluatePoint(IEnumerable<ActionCard> cards)
    {
        var points = CategoryFormula.CalculateCombo(cards);
        if (cards.Any(card => card.category == JudgeSO.baseCategory))
        {
            points *= (int) Mathf.Ceil(points * 1.2f);
        }

        PointText.text = points.ToString();
        return points;
    }
}