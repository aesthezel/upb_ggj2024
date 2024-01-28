using System.Collections.Generic;
using UnityEngine;

public class JudgeHandler : MonoBehaviour
{
    public JudgeRuntime[] Judges;
    public readonly Dictionary<int, JudgeResult[]> JudgeResults = new();
    
    public void FinalCombo(int round, IEnumerable<ActionCard> cards)
    {
        var results = new List<JudgeResult>();
        
        foreach (var judge in Judges)
        {
            results.Add(new JudgeResult()
            {
              Judge = judge.JudgeSO,
              Points = judge.EvaluatePoint(cards)
            });
        }
        
        JudgeResults.TryAdd(round, results.ToArray());
    }
}

public struct JudgeResult
{
    public Judge Judge;
    public int Points;
}