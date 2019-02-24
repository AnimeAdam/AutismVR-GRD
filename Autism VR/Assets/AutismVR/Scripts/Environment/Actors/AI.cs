using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class AI : MonoBehaviour {

    public enum States { Idle, Walk, Run, Work, Sitting, G_TItem, Drinking, Eating, Telephone, Talking} //G_TItem = Give/Take Item
    [SerializeField]private States currentState = States.Idle;
    private States previousState = States.Idle;
    public  States currentState_gs{get { return currentState;}set { currentState = value;}}


    public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
    public ThirdPersonCharacter character { get; private set; } // the character we are controlling
    public Vector3 target = Vector3.zero;                                    // target to aim for

    private float timer = 0f;


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
        /*          //TEST CODE
        if (target != Vector3.zero)
            agent.SetDestination(target);

        if (agent.remainingDistance > agent.stoppingDistance)
            character.Move(agent.desiredVelocity);
        else
        {
            character.Move(Vector3.zero, false, false);
        }*/
                  //TEST CODE

        /*        //TEST CODE
        timer += Time.deltaTime;
        if (timer > 10f && timer < 15f)
        {
            character.Sitting(true);
            timer = 20f;
        }
        */        //TEST CODE
        ChangeState();
    }

    public void ChangeState()
    {
        if (currentState != previousState)
        {
            switch (previousState)
            {
                case States.Idle:
                    break;
                case States.Sitting:
                    character.Sitting(false);
                    break;
                default:
                    Debug.Log("AI HAS NO PREVIOUS STATE");
                    break;
            }
            switch (currentState)
            {
                case States.Idle:
                    break;
                case States.Sitting:
                    character.Sitting(true);
                    break;
                default:
                    Debug.Log("AI HAS NO STATE");
                    break;
            }
            previousState = currentState;
        }
    }
}
