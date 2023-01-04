using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public enum gameStates
    {
        TitleScreen,
        MainMenu,
        Lobby,
        MembersProfile,
        Options

    }

    public gameStates currentStates = gameStates.TitleScreen;

    
}
