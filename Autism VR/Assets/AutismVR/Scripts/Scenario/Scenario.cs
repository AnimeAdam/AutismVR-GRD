using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scenario", menuName = "Scenario Creator/Scenario", order = 1)]
public class Scenario : ScriptableObject
{
    [Header("NPC Information")]
    public List<GameObject> NPCs;
    public List<Sequence> NPC_AI;

    [Header("Objectives")]
    public List<Objective> Objectives;
    
}
