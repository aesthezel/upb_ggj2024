using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Card", menuName = "ActionCards")]
public class ActionCard : ScriptableObject
{

    public string actionName;

    public Categories category;

    public int points;

    public Animation animation;

    public Sprite sprite;

    public Sprite card;

    public string description;

    public enum CardType
    {
        animation,
        spawner,
        ragdoll,
    }

    public CardType cardType;

    public GameObject spawnObject;

    

}
