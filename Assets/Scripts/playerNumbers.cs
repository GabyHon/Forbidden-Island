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

    public bool Two = false;
    public bool Three = false;
    public bool Four = false;

    void Update()
    {
        switch (players)
        {
            case HowManyPlayers.Select:
                Two = false;
                Three = false;
                Four = false;
                print("Please select the number of players");
                break;
            case HowManyPlayers.Two:
                Two = true;
                Three = false;
                Four = false;
                print("2 Players");
                break;
            case HowManyPlayers.Three:
                Two = false;
                Three = true;
                Four = false;
                print("3 Players");
                break;
            case HowManyPlayers.Four:
                Two = false;
                Three = false;
                Four = true;
                print("4 Players");
                break;
        }
    }
}
