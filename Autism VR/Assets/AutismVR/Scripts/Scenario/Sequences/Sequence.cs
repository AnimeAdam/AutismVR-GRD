using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCAI", menuName = "Scenario Creator/NPC Sequence AI", order = 2)]
public class Sequence : ScriptableObject
{
    public string NPCname = "NPC1";
    public Vector3 spawnPoint;
    public Vector3 direction;
    public Vector3[] targets = new Vector3[20];
    public AI.States State;
}
