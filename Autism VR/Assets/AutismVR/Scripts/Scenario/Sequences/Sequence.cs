using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCAI", menuName = "Scenario Creator/NPC Sequence AI", order = 2)]
public class Sequence : ScriptableObject
{
    public string NPCname = "NPC1";
    public Vector3 spawnPoint;
    public ScenarioManager.Facing facingDirection;
    public List<Vector3> targets;
    public bool loop;


    public AI.States State;
}
