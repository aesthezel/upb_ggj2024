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
        
        Debug.Log(points);
        
        if (cards.Any(card => card.category == JudgeSO.baseCategory)) // TODO: Agregar el color morado si lo tiene en ese momento el juez
        {
            points = (int)(points * 1.2f);
        }
        else
        {
            points = (int)(points * 0.8f);
        }

        PointText.text = points.ToString();
        return points;
    }
}