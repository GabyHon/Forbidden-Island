using System;
using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public int turnPhase;
    public bool gameStart;
    public GameObject[] _player1;
    public GameObject[] _player2;
    public GameObject[] _player3;
    public GameObject[] _player4;
    public GameObject[] _TreasureCardsObjects;
    public int topOfDeck = 0;
    public GameObject gameManager;
    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = gameManager.GetComponent<GameManager>();
    }

    private void Update()
    {
        var tdLength = _gameManager.treasureCards.Length;
        for (int i = 0; i < tdLength; i++)
        {
            //Debug.Log(_TreasureCardsObjects.Length + " Length");
            _TreasureCardsObjects[i] = _gameManager.treasureCards[i];
            //Debug.Log("aiygb");
        }

        if (gameStart == true && _TreasureCardsObjects.Length > 9)
        {
            for (int i = 0; i < 2; i++)
            {
                _player1[i] = _TreasureCardsObjects[topOfDeck];
                _player2[i] = _TreasureCardsObjects[topOfDeck + 1];
                _player3[i] = _TreasureCardsObjects[topOfDeck + 2];
                _player4[i] = _TreasureCardsObjects[topOfDeck + 3];
                topOfDeck = topOfDeck + 4;
            }

            gameStart = false;
        }

        if (turnPhase == 1)
        {
        }
        else if (turnPhase == 2)
        {
        }
        else if (turnPhase == 3)
        {
        }
        else
        {
        }
    }
}