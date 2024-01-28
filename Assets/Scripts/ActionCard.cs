using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName ="New Card", menuName = "ActionCards")]
public class ActionCard : ScriptableObject
{

    public string actionName;

    [FormerlySerializedAs("category")] public Category category;

    public int points;

    public Animation animation;

    public Sprite sprite;

    public enum CardType
    {
        animation,
        spawner,
        ragdoll,
    }

    public CardType cardType;

    public GameObject spawnObject;

    

}
