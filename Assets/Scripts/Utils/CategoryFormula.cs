using System.Collections.Generic;

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
                if (lastCategory.AdjecentCategory == action.category.AdjecentCategory)
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
}