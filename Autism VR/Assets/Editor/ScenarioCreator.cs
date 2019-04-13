using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ScenarioCreator : EditorWindow
{
    private static int scenarioNum = 0;
    private static int sequenceNum = 0;
    private static int objectiveNum = 0;
    private static int dialogueNum = 0;

    #region Initalise

    [MenuItem("Scenario Creator/Create Scenario Setup")] 
    static void CreateScenario()
    {
        Instantiate(Resources.Load("AIs/UMA/UMA_DCS"), Vector3.zero,Quaternion.identity);
        Instantiate(Resources.Load("Prefabs/ScenarioManager"), Vector3.zero, Quaternion.identity);
        Instantiate(Resources.Load("Prefabs/UI"), Vector3.zero, Quaternion.identity);
        Instantiate(Resources.Load("Prefabs/FPSController 1"), new Vector3(0f,1f,0f), Quaternion.identity);
    }

    #endregion

    #region Create Building Blocks


    [MenuItem("Scenario Creator/Create Scenario")]
    static void CreateScenarioSO()
    {
        Scenario asset = ScriptableObject.CreateInstance<Scenario>();

        AssetDatabase.CreateAsset(asset, "Assets/Scenarios/Scenario/Scenario" + scenarioNum + ".asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;

        scenarioNum++;
    }

    [MenuItem("Scenario Creator/Create Sequence")]
    static void CreateSequenceSO()
    {
        Sequence asset = ScriptableObject.CreateInstance<Sequence>();

        AssetDatabase.CreateAsset(asset, "Assets/Scenarios/AI Sequence/Sequence" + sequenceNum + ".asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;

        scenarioNum++;
    }

    [MenuItem("Scenario Creator/Create Objective")]
    static void CreateObjectiveSO()
    {
        Objective asset = ScriptableObject.CreateInstance<Objective>();

        AssetDatabase.CreateAsset(asset, "Assets/Scenarios/Objective/Objective" + objectiveNum + ".asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;

        scenarioNum++;
    }

    [MenuItem("Scenario Creator/Create Dialogue")]
    static void CreateDialogueSO()
    {
        Dialogue asset = ScriptableObject.CreateInstance<Dialogue>();

        AssetDatabase.CreateAsset(asset, "Assets/Scenarios/Dialogue/Dialogue" + dialogueNum + ".asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;

        scenarioNum++;
    }

    #endregion

}
