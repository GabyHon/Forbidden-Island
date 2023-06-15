using System;
using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public int turnPhase;
    public bool gameStart;
    public List<GameObject> _player1;
    public List<GameObject> _player2;
    public List<GameObject> _player3;
    public List<GameObject> _player4;
    public List<GameObject> _TreasureCardsObjects;
    public int topOfDeck = 0;
    public GameObject gameManager;
    private GameManager _gameManager;
    [SerializeField] private CardShuffler floodCards;

    private void Start()
    {
        _gameManager = gameManager.GetComponent<GameManager>();
    }

    private void Update()
    {
        var tdLength = _gameManager.treasureCards.Count;
        for (int i = 0; i < tdLength; i++)
        {
            //Debug.Log(_TreasureCardsObjects.Length + " Length");
            _TreasureCardsObjects[i] = _gameManager.treasureCards[i];
            //Debug.Log("aiygb");
        }

        if (gameStart == true && _TreasureCardsObjects.Count > 9 && _gameManager.treasreShuffle == true)
        {
            for (int i = 0; i < 2; i++)
            {
                _player1[i] = floodCards._object[0];
                _player2[i] = floodCards._object[1];
                _player3[i] = floodCards._object[2];
                _player4[i] = floodCards._object[3];
                floodCards._object.RemoveAt(0);
                floodCards._object.RemoveAt(0);
                floodCards._object.RemoveAt(0);
                floodCards._object.RemoveAt(0);
                
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