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
    [SerializeField] private CardShuffler treasureCards;
    [SerializeField] private GameSystem gs;

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
            if (gs.no_Players == 4)
            {
                for (int i = 0; i < 2; i++)
                {
                    _player1[i] = treasureCards._object[0];
                    _player2[i] = treasureCards._object[1];
                    _player3[i] = treasureCards._object[2];
                    _player4[i] = treasureCards._object[3];
                    treasureCards._object.RemoveAt(0);
                    treasureCards._object.RemoveAt(0);
                    treasureCards._object.RemoveAt(0);
                    treasureCards._object.RemoveAt(0);
                
                }
            }
            else if (gs.no_Players == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    _player1[i] = treasureCards._object[0];
                    _player2[i] = treasureCards._object[1];
                    _player3[i] = treasureCards._object[2];
                    treasureCards._object.RemoveAt(0);
                    treasureCards._object.RemoveAt(0);
                    treasureCards._object.RemoveAt(0);
                
                }
            }
            else if (gs.no_Players == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    _player1[i] = treasureCards._object[0];
                    _player2[i] = treasureCards._object[1];
                    treasureCards._object.RemoveAt(0);
                    treasureCards._object.RemoveAt(0);
                
                }
            }

            gameStart = false;
        }
    }
}