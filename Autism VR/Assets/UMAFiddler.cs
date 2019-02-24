using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;

public class UMAFiddler : MonoBehaviour
{

    private DynamicCharacterAvatar avatar;
    private Dictionary<string, DnaSetter> dna;

    // Start is called before the first frame update
    void Start()
    {
        avatar = GetComponent<DynamicCharacterAvatar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            avatar.SetSlot("Helmet", "MaleRobe Hood");
            avatar.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            avatar.ClearSlot("Helmet");
            avatar.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (dna == null)
            {
                dna = avatar.GetDNA(); //HumanMaleDynamicDnaAsset
            }
            dna["headSize"].Set(1f);
            avatar.BuildCharacter();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            avatar.SetColor("Hair", Color.black);
            avatar.BuildCharacter();
        }
    }
}
