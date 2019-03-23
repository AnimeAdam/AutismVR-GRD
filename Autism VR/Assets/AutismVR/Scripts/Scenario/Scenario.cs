using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scenario", menuName = "Scenario Creator/Scenario", order = 1)]
public class Scenario : ScriptableObject
{
    [Header("NPC Information")]
    public GameObject[] NPCs = new GameObject[20];
    public Sequence[] NPC_AI = new Sequence[20];

    [Header("Objectives")]
    public Objective[] Objectives = new Objective[20];
    
}
