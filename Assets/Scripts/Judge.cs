using UnityEngine;

[CreateAssetMenu(fileName ="New Judge", menuName = "Scriptable Objects/Judge")]
public class Judge : ScriptableObject
{
    public string judgeName;
    public Category baseCategory;
    public Sprite sprite;
}