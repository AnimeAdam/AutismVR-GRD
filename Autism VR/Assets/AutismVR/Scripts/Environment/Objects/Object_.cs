using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Object_ : MonoBehaviour
{
    public int objectID;

    public Vector3 startingPosition;

    public enum ObjectType
    {
        Furniture,
        Lighting,
        Plumbing,
        Electronics,
        Decorations,
        Misc,
        Kids_Stuff,
        Floor,
        Building,
        Walls
    }

    public Vector3 chairSittingPosition;

    public static Object_ CreateComponent(GameObject where, int obID)
    {
        Object_ myC = where.AddComponent<Object_>();
        myC.objectID = obID;
        return myC;
    }
    
    // Use this for initialization
    void Start ()
    {
        startingPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
