using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
   
    public List<ActionSlot> actionSlots = new List<ActionSlot>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) { actionSlots[0].PerformAction(); }

        if (Input.GetKeyDown(KeyCode.W)) { actionSlots[1].PerformAction(); }

        if (Input.GetKeyDown(KeyCode.E)) { actionSlots[2].PerformAction(); }

        if (Input.GetKeyDown(KeyCode.R)) { actionSlots[3].PerformAction(); }

        if (Input.GetKeyDown(KeyCode.T)) { actionSlots[4].PerformAction(); }
    }

}
