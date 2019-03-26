using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private GameObject _Objectives_gb;
    private GameObject _Dialogue;

    private List<GameObject> _NPCs;
    private List<Sequence> _NPC_AI;
    private List<Objective> _Objectives;


    // Use this for initialization
    void Start () {
	    
        _UI = GameObject.Find("UI");
        _Objectives_gb = GameObject.Find("Objectives");
        _Dialogue = GameObject.Find("Dialogue");
        SetScenario();
        SetObjectives();
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
            GameObject _UMAAI = _NPCs[i];
            _UMAAI.GetComponent<AI>().currentState_gs = _NPC_AI[i].State;
            _UMAAI.GetComponent<AI>().AIRotation = FacingDirection(_NPC_AI[i].facingDirection);
            _UMAAI.GetComponent<AI>().AIPosition = _NPC_AI[i].spawnPoint;
            Instantiate(_UMAAI, new Vector3(3000f,3000f,3000f),Quaternion.identity);
        }
    }

    Quaternion FacingDirection(Facing _face)
    {
        switch (_face)
        {
            case Facing.North:
                return new Quaternion(0f, 0f, 0f, 0f);
            break;
            case Facing.East:
                return new Quaternion(0f, 90f, 0f, 0f);
            break;
            case Facing.South:
                return new Quaternion(0f, 180f, 0f, 0f);
            break;
            case Facing.West:
                return new Quaternion(0f, 270f, 0f, 0f);
            break;
            default:
                return new Quaternion(0f, 0f, 0f, 0f);
            break;
        }
    }

    void SetObjectives()
    {
        var text = _Objectives_gb.transform.GetChild(0).GetComponent<Text>();
        text.text += _Objectives[0].instructions;
    }

}
