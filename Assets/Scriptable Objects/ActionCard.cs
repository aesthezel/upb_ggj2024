using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Card", menuName = "ActionCards")]
public class ActionCard : ScriptableObject
{

    public string name;

    public enum color
        {

        red,
        blue,
        green

    }

    public int points;

    public Animation animation;

}
