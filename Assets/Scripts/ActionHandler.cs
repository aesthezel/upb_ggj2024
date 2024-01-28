using UnityEngine;

namespace DefaultNamespace
{
    public class ActionHandler : MonoBehaviour
    {
        public ActionSlot[] Slots;
        
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