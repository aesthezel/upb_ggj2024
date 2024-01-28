using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Card", menuName = "ActionCards")]
public class ActionCard : ScriptableObject
{

    public string actionName;

    public Category category;

    public int points;

    public AnimationClip animation;

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
