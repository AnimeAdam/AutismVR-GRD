using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.UI;



public class CharacterCreator: MonoBehaviour
{
    public DynamicCharacterAvatar avatar;

    public void SwitchGender(bool male)
    {
        if (male && avatar.activeRace.name != "HumanMaleDCS")
        {
            avatar.ChangeRace("HumanMaleDCS");
        }
        else if (!male && avatar.activeRace.name != "HumanFemaleDCS")
        {
            avatar.ChangeRace("HumanFemaleDCS");
        }
    }

}
