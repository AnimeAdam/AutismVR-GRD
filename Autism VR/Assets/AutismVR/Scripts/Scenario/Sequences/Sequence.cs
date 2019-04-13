using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UMA.CharacterSystem;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "NPCAI", menuName = "Scenario Creator/AI Sequence", order = 2)]
public class Sequence : ScriptableObject
{
    [Header("NPC Info")] public string NPCname = "NPC1";
    [Header("NPC Start Location")] public Vector3 spawnPoint;

    [Header("NPC Facing direction relative to camera")]
    public ScenarioManager.Facing facingDirection;

    [Header("Points the NPC will move to")]
    public List<Vector3> targets;

    [Header("Should this be looped?")] public bool loop;

    [Header("The state the NPC is in at the beginning")]
    public AI.States State;
}
