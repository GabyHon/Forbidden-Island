using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public int no_Players;
    public int startingDifficulty;

    public void TwoPlayers()
    {
        no_Players = 2;
    }
    public void ThreePlayers()
    {
        no_Players = 3;
    }
    public void FourPlayers()
    {
        no_Players = 4;
    }

    public void Novice()
    {
        startingDifficulty = 0;
    } 
    public void Normal()
    {
        startingDifficulty = 1;
    } 
    public void Elite()
    {
        startingDifficulty = 2;
    } 
    public void Legendary()
    {
        startingDifficulty = 3;
    }
}
