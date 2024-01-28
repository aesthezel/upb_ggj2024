using System;
using System.Collections.Generic;
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
            if (comboDots.Count % 1 == 0 && comboDots.Count > 0)
            {
                var comboResultInstance = Instantiate(ComboResultPrefab, transform);
            }
            
            var comboDotInstance = Instantiate(ComboDotPrefab, transform);
            comboDotInstance.GetComponent<Image>().color = card.category.color;
            
            comboDots.Add(comboDotInstance);
            
            actionCardsPlayed.Add(card);
        }
    }
}