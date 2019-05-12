using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEditor;

public class EnvironmentCreator : EditorWindow
{
    static private int oID = 0;


    #region Furniture

    [MenuItem("Environment Creator/Create Furniture/Bed")]
    static void CreateBed1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Bed") as GameObject;

        CreateAsset(gb, false,
            new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f,
                gb.transform.localScale.z / 3.5f), new Vector3(0f,0.74f,0f));

    }

    [MenuItem("Environment Creator/Create Furniture/Sofa")]
    static void CreateSofa1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Sofa") as GameObject;

        CreateAsset(gb, false,
            new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f,
                gb.transform.localScale.z / 3.5f), new Vector3(0f, 0.35f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Sofa Ver. 2")]
    static void CreateSofa2()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Sofa.1") as GameObject;

        CreateAsset(gb, false,
            new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f,
                gb.transform.localScale.z / 3.5f), new Vector3(0f, 0.35f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Dinner Table")]
    static void CreateDTable1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/TableSet") as GameObject;

        CreateAsset(gb, true,
            new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f,
                gb.transform.localScale.z / 3.5f), new Vector3(0f, 0.63f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Dinner Table Chair")]
    static void CreateDTableC()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/TableChair") as GameObject;

        CreateAsset(gb, false,
            new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f,
                gb.transform.localScale.z / 3.5f), new Vector3(0f, 0.49f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Steel Chair")]
    static void CreateSteelChair()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Chair_Conference") as GameObject;

        CreateAsset(gb, false, new Vector3(1f,1f,1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f,180f,0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Office Chair")]
    static void CreateOfficeChair()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Chair_DeskChair") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Wooden Chair")] 
    static void CreateChair_Thai_01()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/Thai Themed Scene/Prefabs/Chair_Thai_01") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x * 0.7f, gb.transform.localScale.y * 0.7f, gb.transform.localScale.z * 0.7f));
    }

    [MenuItem("Environment Creator/Create Furniture/Wooden Table")]
    static void CreateTable_Thai_01()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/Thai Themed Scene/Prefabs/Table_Thai_01") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x * 0.7f, gb.transform.localScale.y * 0.7f, gb.transform.localScale.z * 0.7f));
    }

    [MenuItem("Environment Creator/Create Furniture/Wooden Table Set")]
    static void CreateTableSetUp_01()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/Thai Themed Scene/Prefabs/Table Set Up_01") as GameObject;

        CreateAsset(gb, true, new Vector3(gb.transform.localScale.x * 0.7f, gb.transform.localScale.y * 0.7f, gb.transform.localScale.z * 0.7f));
    }

    [MenuItem("Environment Creator/Create Furniture/Office Chair Ver. 2")]
    static void CreateOfficeChair2()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Chair_Office") as GameObject;
        
        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f,0f,0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Table")]
    static void CreateTable1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/TVTable") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.37f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Big Drawer")]
    static void CreateBDrawer()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/BigDrawer") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.42f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Bookshelf")]
    static void CreateBShelf()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Bookshelf") as GameObject;

        CreateAsset(gb, true, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.17f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Box Shelf")]
    static void CreateBoxshelf()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Boxshelf") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.4f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Drawer")]
    static void CreateDrawer()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Drawer") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.31f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Small Table")]
    static void CreateSmallTable()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/SmallTable") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.11f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Office Table")]
    static void CreateOfficeTable()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Table_Conference") as GameObject;

        CreateAsset(gb, false, new Vector3(1f,1f,1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Office Desk")]
    static void CreateOfficeDesk()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Table_OfficeDesk") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Furniture/Office Desk Ver. 2")]
    static void CreateOfficeDesk2()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Table_OfficeDesk2") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    #endregion

    #region Lighting

    [MenuItem("Environment Creator/Create Lighting/Tall Lamp")]
    static void CreateTLamp1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/TallLamp") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0.91f, 0f));
    }

    [MenuItem("Environment Creator/Create Lighting/Lamp")]
    static void CreateLamp()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Lamp") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0.23f, 0f));
    }

    [MenuItem("Environment Creator/Create Lighting/Street Lamp")]
    static void CreateStreet_Lamp()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Street_Lamp") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x * 2f) /3.5f , (gb.transform.localScale.y * 2f) / 3.5f, (gb.transform.localScale.z * 2f) / 3.5f), 
            new Vector3(0f, 0.03f, 0f));
    }

    [MenuItem("Environment Creator/Create Lighting/Fluorescent Tube")] 
    static void CreateFluorescentTube()
    {
        var gb = Resources.Load("Prefabs/Extra/Fluorescent Tube Light") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0.1f, 0f));
    }

    #endregion

    #region Plumbing

    [MenuItem("Environment Creator/Create Plumbing/Bath")]
    static void CreateBath1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Bathtub") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f), 
            new Vector3(0f, 0.26f, 0f));
    }

    [MenuItem("Environment Creator/Create Plumbing/Bath Sink")]
    static void CreateBathSink()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/BathSink") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.56f, 0f));
    }

    [MenuItem("Environment Creator/Create Plumbing/Toilet")]
    static void CreateToilet()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Toilet") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.40f, 0f));
    }

    [MenuItem("Environment Creator/Create Plumbing/Kitchen Sink")]
    static void CreateKitchenSink()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Sink") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.43f, 0f));
    }

    [MenuItem("Environment Creator/Create Plumbing/Kitchen Sink Ver. 2")]
    static void CreateKitchenSink2()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Sink.1") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.43f, 0f));
    }

    [MenuItem("Environment Creator/Create Plumbing/Kitchen Sink Ver. 3")]
    static void CreateKitchenSink3()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Sink.2") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.43f, 0f));
    }

    #endregion

    #region Electronics

    [MenuItem("Environment Creator/Create Electronics/TV")]
    static void CreateTV1()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/TV") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.39f, 0f));
    }

    [MenuItem("Environment Creator/Create Electronics/Microwave")]
    static void CreateMicrowave()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Microwave") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.14f, 0f));
    }

    [MenuItem("Environment Creator/Create Electronics/Refrigerator")]
    static void CreateRefrigerator()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Refrigerator") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.76f, 0f));
    }

    [MenuItem("Environment Creator/Create Electronics/Laptop On")]
    static void CreateLaptop_On()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Laptop_On") as GameObject;

        CreateAsset(gb, false, new Vector3(1f,1f,1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Electronics/Laptop Closed")]
    static void CreateLaptop_Closed()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Laptop_Closed") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Electronics/Tablet")]
    static void CreateTablet()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Tablet") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Electronics/CellPhone")]
    static void CreateCellPhone()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/CellPhone") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    #endregion

    #region Decorations

    [MenuItem("Environment Creator/Create Decorations/Mirror")]
    static void CreateMirror()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Mirror") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f), 
            new Vector3(0f, 0.29f, 0f));
    }

    [MenuItem("Environment Creator/Create Decorations/Mirror Stand")]
    static void CreateMirrorStand()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Mirror.1") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.63f, 0f));
    }

    [MenuItem("Environment Creator/Create Decorations/Plant Pot")]
    static void CreatePlantPotLargeA()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/PlantPotLargeA") as GameObject;

        CreateAsset(gb, true, new Vector3(1f,1f,1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Decorations/Stone Plants Plantation")] 
    static void CreateStoneDisplayWithPlants_01()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/Thai Themed Scene/Prefabs/Stone Display With Plants_01") as GameObject;

        CreateAsset(gb, true, new Vector3(gb.transform.localScale.x * 0.7f, gb.transform.localScale.y * 0.7f, gb.transform.localScale.z * 0.7f));
    }

    #endregion

    #region Misc.

    [MenuItem("Environment Creator/Create Misc./Trash Can")]
    static void CreateTrashMan()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Trash") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f), 
            new Vector3(0f, 0.25f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Trash Can Ver. 2")]
    static void CreateTrashMan2TrashHarder()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Trash 1") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.25f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Book")]
    static void CreateB()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Book.1") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Book Ver. 2")]
    static void CreateB2()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Book.2") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Book Ver. 3")]
    static void CreateB3()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Book.3") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Book Ver. 4")]
    static void CreateB4()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Book.4") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Book Ver. 5")]
    static void CreateB5()
    {
        var gb = Resources.Load("3rdParty/HomeStuff/Prefabs/Book.5") as GameObject;
        
        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x / 3.5f, gb.transform.localScale.y / 3.5f, gb.transform.localScale.z / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Briefcase")]
    static void CreateBriefcase()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Briefcase") as GameObject;

        CreateAsset(gb, false, new Vector3(1f,1f,1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }
    
    [MenuItem("Environment Creator/Create Misc./Filling Cabinet")]
    static void CreateFilingCabinetThreeStack_Case()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/FilingCabinetThreeStack_Case") as GameObject;

        CreateAsset(gb, true, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Pen")]
    static void CreatePenClosed()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/PenClosed") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Umbrella Closed")]
    static void CreateUmbrellaClosed()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Umbrella_Closed") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Umbrella Open")]
    static void CreateUmbrellaOpen()
    {
        var gb = Resources.Load("3rdParty/LowPolyOfficeProps_LITE/Prefabs/Umbrella_Open") as GameObject;

        CreateAsset(gb, false, new Vector3(1f, 1f, 1f), new Vector3(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Dumpster")]
    static void CreateDupster_Blue()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Dupster_Blue") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x * 2f) / 3.5f, (gb.transform.localScale.y * 2f) / 3.5f, (gb.transform.localScale.z * 2f) / 3.5f), 
            new Vector3(0f, 0.14f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Hydrant")]
    static void CreateHydrant()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Hydrant") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x * 2f) / 3.5f, (gb.transform.localScale.y * 2f) / 3.5f, (gb.transform.localScale.z * 2f) / 3.5f),
            new Vector3(0f, 0.03f, 0f));
    }

    [MenuItem("Environment Creator/Create Misc./Mail Box")]
    static void CreateMailBox()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/MailBox") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x * 2f) / 3.5f, (gb.transform.localScale.y * 2f) / 3.5f, (gb.transform.localScale.z * 2f) / 3.5f),
            new Vector3(0f, 0.03f, 0f));
    }

    #endregion

    #region Kids

    [MenuItem("Environment Creator/Create Kids Stuff/Monkey Bars")]
    static void CreateMonkeyBars()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Monkey Bars") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 1.72f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/Playground")]
    static void CreatePlayground()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Playground") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.21f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/Roundabout")]
    static void CreateRoundabout()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Roundabout") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.81f, 0f), Quaternion.Euler(0f, 180f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/Sandbox")]
    static void CreateSandbox()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Sandbox") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, -0.06f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/SeeSaw")]
    static void CreateSeeSaw()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/SeeSaw") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.22f, 0f), Quaternion.Euler(0f, -90f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/Slide")]
    static void CreateSlide()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Slide") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 1.23f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/Sliding Pole")]
    static void CreateSlidingPole()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Sliding Pole") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.05f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }

    [MenuItem("Environment Creator/Create Kids Stuff/Swing Set")]
    static void CreateSwingSet()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Swing Set") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 1.1f, 0f), Quaternion.Euler(0f, -90f, 0f));
    }

    #endregion

    #region Floor

    [MenuItem("Environment Creator/Create Floor/Playground Lot")]
    static void CreatePlaygroundLot()
    {
        var gb = Resources.Load("3rdParty/PlayGround Pack/Prefabs/Playground Lot") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.21f, 0f));
    }

    [MenuItem("Environment Creator/Create Floor/Plane Road")]
    static void CreatePlane_Road()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Plane_Road") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.3f, 0f));
    }

    [MenuItem("Environment Creator/Create Floor/Plane Sidewalk")]
    static void CreatePlane_Sidewalk()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Plane_Sidewalk") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.3f, 0f));
    }

    [MenuItem("Environment Creator/Create Floor/Road Straight")]
    static void CreateRoad_Straight_A()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Road_Straight_A") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.3f, 0f));
    }

    [MenuItem("Environment Creator/Create Floor/Crosswalk")]
    static void CreateRoad_Road_Straight_B()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Road_Straight_B") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.3f, 0f));
    }

    #endregion

    #region Buiolding

    [MenuItem("Environment Creator/Create Buildings/Apartment Blue")]
    static void CreateApartment_01_Blue()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_01_Blue") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Brown")]
    static void CreateApartment_01_Brown()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_01_Brown") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Green")]
    static void CreateApartment_01_Green()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_01_Green") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Red")]
    static void CreateApartment_01_Red()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_01_Red") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Yellow")]
    static void CreateApartment_01_Yellow()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_01_Yellow") as GameObject;

        CreateAsset(gb, true, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.1f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Ver. 2 Blue")]
    static void CreateApartment_02_Blue()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_02_Blue") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.23f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Ver. 2 Brown")]
    static void CreateApartment_02_Brown()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_02_Brown") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.23f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Ver. 2 Green")]
    static void CreateApartment_02_Green()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_02_Green") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.23f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Ver. 2 Red")]
    static void CreateApartment_02_Red()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_02_Red") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.23f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Apartment Ver. 2 Yellow")]
    static void CreateApartment_02_Yellow()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Apartment_02_Yellow") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.23f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Hot Dog Restaurant")]
    static void CreateHot_Dog_Restaurant()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Hot_Dog_Restaurant") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.21f, 0f));
    }

    [MenuItem("Environment Creator/Create Buildings/Pawn Shop")]
    static void CreatePawn_Shop()
    {
        var gb = Resources.Load("3rdParty/Simple_City_Lite/Prefabs/Pawn_Shop") as GameObject;

        CreateAsset(gb, false, new Vector3((gb.transform.localScale.x / 1.5f) / 3.5f, (gb.transform.localScale.y / 1.5f) / 3.5f, (gb.transform.localScale.z / 1.5f) / 3.5f),
            new Vector3(0f, 0.03f, 0f));
    }

    #endregion

    #region Walls

    [MenuItem("Environment Creator/Create Walls/Brick Wall")] 
    static void CreateBulidingFloorPlane()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/SE Basic Assets/Prefabs/Buliding FloorPlane") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x * 0.75f, gb.transform.localScale.y * 0.75f, gb.transform.localScale.z * 0.75f),
            new Vector3(0f, 3.8f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }

    [MenuItem("Environment Creator/Create Walls/Concrete Wall")]
    static void CreateConcretePlane()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/SE Basic Assets/Prefabs/Concrete Plane") as GameObject;

        CreateAsset(gb, false, new Vector3(gb.transform.localScale.x * 0.75f, gb.transform.localScale.y * 0.75f, gb.transform.localScale.z * 0.75f),
            new Vector3(0f, 3.8f, 0f), Quaternion.Euler(-90f, 0f, 0f));
    }

    [MenuItem("Environment Creator/Create Walls/Stone Wall")]
    static void CreateStoneWall()
    {
        var gb = Resources.Load("3rdParty/Soja Exiles/Thai Themed Scene/Prefabs/Wall Sculpture_01") as GameObject;

        CreateAsset(gb, false);
    }

    [MenuItem("Environment Creator/Create Walls/Plane Wall")]
    static void CreatePlaneWall()
    {
        var gb = Resources.Load("Prefabs/Extra/PlaneWall") as GameObject;

        CreateAsset(gb, false);
    }

    #endregion

    #region Ceiling



    #endregion

    #region ASSETBUILDING
    
    static void CreateAsset(GameObject gb, bool manyGBs)
    {
        GameObject gb_ = Instantiate(gb, Vector3.zero, Quaternion.identity);

        if (!manyGBs)
        {
            AddComponents(gb_);
        }
        else
        {
            Transform[] trans = gb_.GetComponentsInChildren<Transform>();
            foreach (Transform _tran in trans)
            {
                AddComponents(_tran.gameObject);
            }
        }
    }

    static void CreateAsset(GameObject gb, bool manyGBs, Vector3 scale)
    {
        GameObject gb_ = Instantiate(gb, Vector3.zero, Quaternion.identity);

        gb_.transform.localScale = scale;

        if (!manyGBs)
        {
            AddComponents(gb_);
        }
        else
        {
            Transform[] trans = gb_.GetComponentsInChildren<Transform>();
            foreach (Transform _tran in trans)
            {
                AddComponents(_tran.gameObject);
            }
        }
    }

    static void CreateAsset(GameObject gb, bool manyGBs, Vector3 scale, Vector3 pos)
    {
        GameObject gb_ = Instantiate(gb, Vector3.zero, Quaternion.identity);

        gb_.transform.localScale = scale;
        gb_.transform.localPosition = pos;
        
        if (!manyGBs)
        {
            AddComponents(gb_);
        }
        else
        {
            Transform[] trans = gb_.GetComponentsInChildren<Transform>();
            foreach (Transform _tran in trans)
            {
                AddComponents(_tran.gameObject);
            }
        }
    }

    static void CreateAsset(GameObject gb, bool manyGBs, Vector3 scale, Vector3 pos, Quaternion rot)
    {
        GameObject gb_ = Instantiate(gb, Vector3.zero, Quaternion.identity);

        gb_.transform.localScale = scale;
        gb_.transform.localPosition = pos;
        gb_.transform.localRotation = rot;

        if (!manyGBs)
        {
            AddComponents(gb_);
        }
        else
        {
            Transform[] trans = gb_.GetComponentsInChildren<Transform>();
            foreach (Transform _tran in trans)
            {
                AddComponents(_tran.gameObject);
            }
        }
    }

    static void AddComponents(GameObject gb)
    {
        Object_ ob = Object_.CreateComponent(gb, oID);
        oID++;
        gb.AddComponent<Audio_>();

        if (gb.GetComponent<BoxCollider>() == null)
        {
            gb.AddComponent<BoxCollider>();
        }
    }

    #endregion

}