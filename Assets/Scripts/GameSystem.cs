using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public int no_Players;
    public int startingDifficulty;
    [SerializeField] private GameObject[] levelPos;
    [SerializeField] private GameObject lvlPlaceKeeper;
    [SerializeField] private PlayeHand player_hand;

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
        lvlPlaceKeeper.transform.position = levelPos[startingDifficulty].transform.position;
        player_hand._gameStart = true;
    } 
    public void Normal()
    {
        startingDifficulty = 1;
        lvlPlaceKeeper.transform.position = levelPos[startingDifficulty].transform.position;
        player_hand._gameStart = true;
    } 
    public void Elite()
    {
        startingDifficulty = 2;
        lvlPlaceKeeper.transform.position = levelPos[startingDifficulty].transform.position;
        player_hand._gameStart = true;
    } 
    public void Legendary()
    {
        startingDifficulty = 3;
        lvlPlaceKeeper.transform.position = levelPos[startingDifficulty].transform.position;
        player_hand._gameStart = true;
    }
}
