using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public Scenario Scenarios;
    [HideInInspector]public enum Facing
    {
        North,
        East,
        South,
        West
    }

    private GameObject _UI;

    private List<GameObject> _NPCs;
    private List<Sequence> _NPC_AI;
    private List<Objective> _Objectives;


    // Use this for initialization
    void Start () {
	    
        _UI = GameObject.Find("UI");
        SetScenario();
        SpawnAIs();

    }
	
	// Update is called once per frame
	void Update () {
		


	}

    private void SetScenario()
    {
        _NPCs = Scenarios.NPCs;
        _NPC_AI = Scenarios.NPC_AI;
        _Objectives = Scenarios.Objectives;
    }

    void SpawnAIs()
    {
        for (int i = 0; i < _NPCs.Count; i++)
        {
            Instantiate(_NPCs[i],_NPC_AI[i].spawnPoint,Quaternion.identity);
        }
    }

}
