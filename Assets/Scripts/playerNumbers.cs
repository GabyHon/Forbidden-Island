using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerNumbers : MonoBehaviour
{
    [SerializeField] private int howManyPlayers = 2;

    // Update is called once per frame
    void Update()
    {
        switch (howManyPlayers)
        {
            case 1:
                print("3 Players");
                break;
            case 2:
                print("4 Players");
                break;
            default:
                print("2 Players");
                break;
        }
    }
}
