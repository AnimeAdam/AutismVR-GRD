using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "Objective", menuName = "Scenario Creator/Objective", order = 3)]
public class Objective : ScriptableObject
{
    public string instructions = "";    //Instructions for what the player has to do
    public Vector3 targetLocation = new Vector3(0f,0f,0f);  //Go to here
    public Vector3 lookingLocation = new Vector3(0f,0f,0f); //Look there, that has a big trigger box, that the camera ray cast for triggering
    public GameObject NPCTalkTo = null;     //NPC to talk to
    public GameObject ObjectToPickUp = null;


    [HideInInspector] public bool isTaskCompleted = false;
    [HideInInspector] public bool FAILED = false;
}
