using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class ActionHandler : MonoBehaviour
    {
        public ActionSlot[] Slots;
        private List<ActionCard> _usedSlot = new();

        private void Start()
        {
            foreach (var slot in Slots)
            {
                slot.OnUsed += SlotUsed;
            }
        }

        private void OnDestroy()
        {
            foreach (var slot in Slots)
            {
                slot.OnUsed -= SlotUsed;
            }
        }

        private void SlotUsed(ActionCard card)
        {
            _usedSlot.Add(card);

            var allPerformed = Slots.Where(slot => slot.gameObject.activeInHierarchy).All(slot => slot.IsPerformed);
            
            Debug.Log($"Slot used! {allPerformed}");
            
            if (!allPerformed) return; 
            Debug.Log("Todas las acciones han sido usadas!");
            AbilitieManager.instance.AllAbilitiesUsed(_usedSlot.ToArray());
        }

        public void UpdateSlots(ActionCardBundle[] bundle)
        {
            for (var i = 0; i < bundle.Length; i++)
            {
                if(!Slots[i].gameObject.activeInHierarchy) Slots[i].gameObject.SetActive(true);
                Slots[i].ChangeAbility(bundle[i].Id, bundle[i].Card);
            }
        }
    }
}