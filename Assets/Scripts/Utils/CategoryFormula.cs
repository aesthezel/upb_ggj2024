using System.Collections.Generic;
using JetBrains.Annotations;

public static class CategoryFormula
{
    public static int CalculateCombo(IEnumerable<ActionCard> actionPerformed)
    {
        var total = 0;
        Category lastCategory = null;
        
        foreach (var action in actionPerformed)
        {
            if (lastCategory == null) // First action
            {
                lastCategory = action.category;
                total += action.points;
            }
            else
            {
                if (lastCategory == action.category.AdjecentCategory)
                {
                    total -= action.points;
                }
                else
                {
                    total += action.points;
                }
            }
        }

        return total;
    }

    public static bool CalculateIsGoodOrBad([CanBeNull] ActionCard lastActionCard, ActionCard currentActionCard)
    {
        if (lastActionCard == null) return true;
        return lastActionCard.category != currentActionCard.category.AdjecentCategory;
    }
}