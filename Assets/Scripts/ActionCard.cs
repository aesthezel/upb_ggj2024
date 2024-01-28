using System.Collections;
using System.Collections.Generic;
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

    public enum cardType
    {
        animation,
        spawner,
        ragdoll,
    }

    public GameObject spawnObject;

}
