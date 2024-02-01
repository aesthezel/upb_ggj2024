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
    public AudioManager.AudioSamples cardAudio;
    //Es importante y obligatorio que este string tenga el mismo nombre del paramentro del animator.
    public string cardAnimation;
    
    public Sprite sprite;

    public Sprite card;

    public string description;

    public enum CardType
    {
        animation,
        spawner,
       
    }

    public CardType cardType;

    public GameObject spawnObject;

   


}
