using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerNumbers : MonoBehaviour
{
    public enum HowManyPlayers
    {
        Select, Two, Three, Four
    }

    public HowManyPlayers players;

    // Update is called once per frame
    void Update()
    {
        switch (players)
        {
            case HowManyPlayers.Select:
                print("Please select the number of players");
                break;
            case HowManyPlayers.Two:
                print("2 Players");
                break;
            case HowManyPlayers.Three:
                print("3 Players");
                break;
            case HowManyPlayers.Four:
                print("4 Players");
                break;
        }
    }
}
