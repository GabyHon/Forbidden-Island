using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayeHand : MonoBehaviour
{
    public GameObject[] handPositions;
    private int no_Players;
    private bool isPlayerPlaying;
    private int currentPlayer;
    private bool GameOver = false;
    private bool turnOver;
    private bool gameStart;
    private int currentTurn;
    private GameObject[] player1;
    private GameObject[] player2;
    private GameObject[] player3;
    private GameObject[] player4;
    private GameObject[] offHand;
    public GameObject turnManager;
    private TurnManager _turnManager;

    private void Start()
    {
        _turnManager = turnManager.GetComponent<TurnManager>();
    }

    private void Update()
    {
        if (gameStart == true)
        {
            currentPlayer = 1;
            gameStart = false;
        }

        if (_turnManager._player1.Length == 2)
        {
            for (int i = 0; i < 5; i++)
            {
                player1[i] = _turnManager._player1[i];
                player2[i] = _turnManager._player2[i];
                player3[i] = _turnManager._player3[i];
                player4[i] = _turnManager._player4[i];
            }
        }

        if (currentPlayer == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                player4[i].transform.position = offHand[3].transform.position;
                player1[i].transform.position = handPositions[i].transform.position;
            }
        }

        else if (currentPlayer == 2)
        {
            for (int i = 0; i < 5; i++)
            {
                player1[i].transform.position = offHand[0].transform.position;
                player2[i].transform.position = handPositions[i].transform.position;
            }
        }

        else if (currentPlayer == 3)
        {
            for (int i = 0; i < 5; i++)
            {
                player2[i].transform.position = offHand[1].transform.position;
                player3[i].transform.position = handPositions[i].transform.position;
            }
        }
        else if (currentPlayer == 4)
        {
            for (int i = 0; i < 5; i++)
            {
                player3[i].transform.position = offHand[2].transform.position;
                player4[i].transform.position = handPositions[i].transform.position;
                
            }
        }
    }
}
