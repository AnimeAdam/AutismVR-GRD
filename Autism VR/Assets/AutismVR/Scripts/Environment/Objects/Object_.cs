using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Object_ : MonoBehaviour
{
    public int objectID;

    public Vector3 position;            //Find some way to budge the NPC

    public static Object_ CreateComponent(GameObject where, int obID)
    {
        Object_ myC = where.AddComponent<Object_>();
        myC.objectID = obID;
        return myC;
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
