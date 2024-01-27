
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    //End up switching for 
    public string message;

    private void OnMouseEnter()
    {
        Debug.Log("Something is touching me");
        ToolTipManager._instance.SetAndShowToolTip(message);
    }

    private void OnMouseExit()
    {
        Debug.Log("it stoped");
        ToolTipManager._instance.HideToolTip();

    }

}
