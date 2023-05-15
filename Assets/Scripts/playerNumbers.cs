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
        Debug.Log("Two Players have been selected");
    }

    public void ThreePlayersButton()
    {
        ThreePlayers = true;
        Debug.Log("Three Players have been selected");
    }

    public void FourPlayersButton()
    {
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
