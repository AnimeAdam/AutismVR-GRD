using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnvironmentCreator : EditorWindow
{
    static private int oID = 0;

    [MenuItem("Environment Creator/Create Furniture/Bed")]
    static void CreateBed1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/Bed") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);                  //Find alternative it give the prefab the script
        Instantiate(gb, new Vector3(0f,2.6f,0f), Quaternion.identity);
        oID++;
        DestroyImmediate(ob);
    }

    [MenuItem("Environment Creator/Create Furniture/Sofa")]
    static void CreateSofa1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/Sofa") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);
        Instantiate(gb, new Vector3(0f, 2.6f, 0f), Quaternion.identity);
        oID++;
    }

    [MenuItem("Environment Creator/Create Furniture/Dinner Table")]
    static void CreateDTable1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/Table") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);
        Instantiate(gb, new Vector3(0f, 2.6f, 0f), Quaternion.identity);
        oID++;
    }

    [MenuItem("Environment Creator/Create Furniture/Table")]
    static void CreateTable1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/TVTable") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);
        Instantiate(gb, new Vector3(0f, 2.6f, 0f), Quaternion.identity);
        oID++;
    }

    [MenuItem("Environment Creator/Create Lighting/Tall Lamp")]
    static void CreateTLamp1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/TallLamp") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);
        Instantiate(gb, new Vector3(0f, 2.6f, 0f), Quaternion.identity);
        oID++;
    }

    [MenuItem("Environment Creator/Create Plumbing/Bath")]
    static void CreateBath1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/Bathtub") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);
        Instantiate(gb, new Vector3(0f, 2.6f, 0f), Quaternion.identity);
        oID++;
    }

    [MenuItem("Environment Creator/Create Entertainment/TV")]
    static void CreateTV1()
    {
        var gb = Resources.Load("HomeStuff/Prefabs/TV") as GameObject;
        Object_ ob = Object_.CreateComponent(gb, oID);
        Instantiate(gb, new Vector3(0f, 2.6f, 0f), Quaternion.identity);
        oID++;
    }
}
