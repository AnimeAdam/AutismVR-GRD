using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Scenario Creator/Dialogue", order = 4)]
public class Dialogue : ScriptableObject
{
    [Header("Dialogue Name")]
    public string dialogueName;

    [Header("Dialogue")]
    public string dialogue;
}
