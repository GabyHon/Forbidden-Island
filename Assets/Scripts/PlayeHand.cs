using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayeHand : MonoBehaviour
{
    public GameObject[] handPositions;
    [SerializeField] private int _noPlayers;
    [SerializeField] private bool _isPlayerPlaying;
    [SerializeField] private int _currentPlayer = 0;
    [SerializeField] private bool _gameOver = false;
    [SerializeField] private bool _turnOver;
    //[SerializeField] private bool _gameStart = false;
    public bool _gameStart = false;
    [SerializeField] private int _currentTurn;
    [SerializeField] private GameObject[] _player1;
    [SerializeField] private GameObject[] _player2;
    [SerializeField] private GameObject[] _player3;
    [SerializeField] private GameObject[] _player4;
    [SerializeField] private GameObject offHand;
    [SerializeField] private Vector3[] _handPositions;
    public GameObject turnManager;
    [SerializeField] private TurnManager _turnManager;
    [SerializeField] private Transform HandPositions;

    private void Start()
    {
        _turnManager = turnManager.GetComponent<TurnManager>();
        //_gameStart = false;
        //_gameStart = true;
    }

    private void Update()
    {
        //Debug.Log(_currentPlayer);
        if (_gameStart)
        {
            _currentPlayer = 1;
            Debug.Log(_currentPlayer + " On Game Start");
            //_gameStart = false;
        }

        if (_turnManager._player1.Length >= 2)
        {
            for (int i = 0; i < 5; i++)
            {
                _player1[i] = _turnManager._player1[i];
                _player2[i] = _turnManager._player2[i];
                _player3[i] = _turnManager._player3[i];
                _player4[i] = _turnManager._player4[i];
            }
        }

        
        switch (_currentPlayer)
        {
            case 1:
            {
                for (int i = 0; i < 5; i++)
                {
                   _player4[i].transform.SetParent(null);
                    _player4[i].transform.position = offHand.transform.position;
                    _player1[i].transform.SetParent(HandPositions);
                    _player1[i].transform.position = handPositions[i].transform.position;
                   // Debug.Log("it works");
                   // Debug.Log(_player1[0]);
                }

                break;
            }
            case 2:
            {
                for (int i = 0; i < 5; i++)
                {
                    _player1[i].GameObject().transform.position = offHand.GameObject().transform.position;
                    _player2[i].gameObject.transform.position = handPositions[i].gameObject.transform.position;
                }

                break;
            }
            case 3:
            {
                for (int i = 0; i < 5; i++)
                {
                    _player2[i].gameObject.transform.position = offHand.gameObject.transform.position;
                    _player3[i].gameObject.transform.position = handPositions[i].gameObject.transform.position;
                }

                break;
            }
            case 4:
            {
                for (int i = 0; i < 5; i++)
                {
                    _player3[i].gameObject.transform.position = offHand.gameObject.transform.position;
                    _player4[i].gameObject.transform.position = handPositions[i].gameObject.transform.position;
                
                }

                break;
            }
        }
    }
}
