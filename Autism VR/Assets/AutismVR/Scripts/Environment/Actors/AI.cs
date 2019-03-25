using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class AI : MonoBehaviour {

    //States //0x0 is a Hexadecimal lateral 0b00000000 is a btye lateral
    [Flags] public enum States { Idle=0x0, Walk = 0x1, Run = 0x2, Work = 0x4, Sitting = 0x8, G_TItem=0x10, Drinking = 0x20, Eating = 0x40, Telephone = 0x80, Talking = 0x100 } //G_TItem = Give/Take Item  //Run_Test = 0x200
    [SerializeField]private States currentState = States.Idle;
    private States previousState = States.Idle;
    public  States currentState_gs{get { return currentState;}set { currentState = value;}}

    //UMA Requirements
    public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
    public ThirdPersonCharacter character { get; private set; } // the character we are controlling


    public Vector3 target = Vector3.zero;                                    // target to Walk/Run to
    private float timer = 0f;

    public bool goNow = false;


    private void Start()
    {
        // get the components on the object we need ( should not be null due to require component so no need to check )
        agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
        character = GetComponent<ThirdPersonCharacter>();

        agent.updateRotation = false;
        agent.updatePosition = true;

        target = new Vector3(5f,0f,5f);
    }


    private void Update()
    {
        if (goNow)
        {
            if (target != Vector3.zero)
                agent.SetDestination(target);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity);
            else
            {
                character.Move(Vector3.zero, false, false);
            }
        }

        //ChangeState();
    }

    public void ChangeState()
    {
        if (currentState != previousState)
        {
            switch (previousState)
            {
                case States.Idle:
                    break;
                case States.Walk:
                    character.Walk(false, target);           //And targeting system with only walking here
                    break;
                case States.Run:
                    character.Running(false, target);        //And here
                    break;
                case States.Sitting:
                    character.Sitting(false);
                    break;
                case States.Sitting | States.Drinking:
                    character.Sitting(false);
                    character.Drinking(false);
                    break;
                case States.Sitting | States.G_TItem:
                    character.Sitting(false);
                    character.G_TItem(false);
                    break;
                case States.Sitting | States.Talking:
                    character.Sitting(false);
                    character.Talking(false);
                    break;
                case States.Sitting | States.Work:
                    character.Sitting(false);
                    character.Work(false);
                    break;
                case States.Sitting | States.Eating:
                    character.Sitting(false);
                    character.Eating(false);
                    break;
                case States.G_TItem:
                    character.G_TItem(false);
                    break;
                case States.Drinking:
                    character.Drinking(false);
                    break;
                case States.Talking:
                    character.Talking(false);
                    break;
                case States.Telephone:
                    character.Telephone(false);
                    break;
                default:
                    Debug.Log("AI HAS NO PREVIOUS STATE");
                    break;
            }
            switch (currentState)
            {
                case States.Idle:
                    break;
                case States.Walk:
                    character.Walk(true, target);           //And targeting system with only walking here
                    break;
                case States.Run:
                    character.Running(true, target);        //And here
                    break;
                case States.Sitting:
                    character.Sitting(true);
                    break;
                case States.Sitting | States.Drinking:
                    character.Sitting(true);
                    character.Drinking(true);
                    break;
                case States.Sitting | States.G_TItem:
                    character.Sitting(true);
                    character.G_TItem(true);
                    break;
                case States.Sitting | States.Talking:
                    character.Sitting(true);
                    character.Talking(true);
                    break;
                case States.Sitting | States.Work:
                    character.Sitting(true);
                    character.Work(true);
                    break;
                case States.Sitting | States.Eating:
                    character.Sitting(true);
                    character.Eating(true);
                    break;
                case States.G_TItem:
                    character.G_TItem(true);
                    break;
                case States.Drinking:
                    character.Drinking(true);
                    break;
                case States.Talking:
                    character.Talking(true);
                    break;
                case States.Telephone:
                    character.Telephone(true);
                    break;
                default:
                    Debug.Log("AI HAS NO STATE");
                    break;
            }
            previousState = currentState;
        }
    }
}
