using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ComboResultHandler : MonoBehaviour
    {
        public GameObject ComboDotPrefab;
        public GameObject ComboResultPrefab;

        private List<GameObject> comboDots = new();
        private List<ActionCard> actionCardsPlayed = new(); // Deberia obtenerse de otro lado
        private List<GameObject> comboResults = new();
        
        public void ReceiveAction(ActionCard card)
        {
            actionCardsPlayed.Add(card);
            
            if (comboDots.Count % 1 == 0 && comboDots.Count > 0)
            {
                var isGoodCombo = CategoryFormula.CalculateIsGoodOrBad(actionCardsPlayed[^2], actionCardsPlayed[^1]);
                var comboResultInstance = Instantiate(ComboResultPrefab, transform);
                comboResultInstance.GetComponent<ComboResultIndicator>().ChangeImageCombo(isGoodCombo);
            }
            
            var comboDotInstance = Instantiate(ComboDotPrefab, transform);
            comboDotInstance.GetComponent<Image>().color = card.category.color;
            
            comboDots.Add(comboDotInstance);
        }
    }
}