using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class playerNumbers : MonoBehaviour
{
    [SerializeField] public bool TwoPlayers, ThreePlayers, FourPlayers = false;

    public void TwoPlayersButton()
    {
        TwoPlayers = true;
        ThreePlayers = false;
        FourPlayers = false;
        Debug.Log("Two Players have been selected");
    }

    public void ThreePlayersButton()
    {
        TwoPlayers = false;
        ThreePlayers = true;
        FourPlayers = false;
        Debug.Log("Three Players have been selected");
    }

    public void FourPlayersButton()
    {
        TwoPlayers = false;
        ThreePlayers = false;
        FourPlayers = true;
        Debug.Log("Four Players have been selected");
    }

    public void PlayersBackButton()
    {
        TwoPlayers = false;
        ThreePlayers = false;
        FourPlayers = false;
    }
}
