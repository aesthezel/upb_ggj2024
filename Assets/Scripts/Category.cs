using UnityEngine;

[CreateAssetMenu(fileName ="New Category", menuName = "Scriptable Objects/Category")]
public class Category : ScriptableObject
{
    public string CategoryName;
    public Category AdjecentCategory;
    public Color color;
}