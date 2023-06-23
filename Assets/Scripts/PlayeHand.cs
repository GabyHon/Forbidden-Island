using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayeHand : MonoBehaviour
{
    public GameObject[] handPositions;
    [SerializeField] private int _noPlayers;
    [SerializeField] private bool _isPlayerPlaying;
    public int _currentPlayer = 0;
    [SerializeField] private bool _gameOver = false;
    [SerializeField] private bool _turnOver;
    //[SerializeField] private bool _gameStart = false;
    public bool _gameStart = false;
    [SerializeField] private int _currentTurn;
    public List<GameObject> _player1;
    public List<GameObject> _player2;
    public List<GameObject> _player3;
    public List<GameObject> _player4;
    [SerializeField] private GameObject offHand;
    [SerializeField] private Vector3[] _handPositions;
    public GameObject turnManager;
    [SerializeField] private TurnManager _turnManager;
    [SerializeField] private Transform HandPositions;
    [SerializeField] private GameSystem gs;

    private void Start()
    {
        _turnManager = turnManager.GetComponent<TurnManager>();
        _noPlayers = gs.no_Players;
        //_gameStart = false;
        //_gameStart = true;
    }

    private void Update()
    {
        if (_currentPlayer > gs.no_Players)
        {
            _currentPlayer = 1;
        }
        //Debug.Log(_currentPlayer);
        if (_gameStart)
        {
            _currentPlayer = 1;
            Debug.Log(_currentPlayer + " On Game Start");
            if (gs.no_Players == 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    _player1[i] = _turnManager._player1[i];
                    _player2[i] = _turnManager._player2[i];
                    _player3[i] = _turnManager._player3[i];
                    _player4[i] = _turnManager._player4[i];
                }
            }
            else if (gs.no_Players == 3)
            {
                for (int i = 0; i < 5; i++)
                {
                    _player1[i] = _turnManager._player1[i];
                    _player2[i] = _turnManager._player2[i];
                    _player3[i] = _turnManager._player3[i]; 
                } 
            }
            else if (gs.no_Players == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    _player1[i] = _turnManager._player1[i];
                    _player2[i] = _turnManager._player2[i];
                }
            }
            _gameStart = false;
            //Debug.Log();
        }

       

        // change this to a function called on the change of turn
        if (gs.no_Players == 4)
        {
            switch (_currentPlayer)
            {
                case 1:
                {
                    for (int i = 0; i < _player4.Count; i++)
                    {
                        _player4[i].transform.SetParent(null);
                        _player4[i].transform.position = offHand.transform.position;
                        
                        // Debug.Log("it works");
                        // Debug.Log(_player1[0]);
                    }

                    for (int i = 0; i < _player1.Count; i++)
                    {
                        _player1[i].transform.SetParent(HandPositions);
                        _player1[i].transform.position = handPositions[i].transform.position;
                    }

                    break;
                }
                case 2:
                {
                    for (int i = 0; i < _player1.Count; i++)
                    {
                        _player1[i].transform.SetParent(null);
                        _player1[i].transform.position = offHand.transform.position;
                        
                    }

                    for (int i = 0; i < _player2.Count; i++)
                    {
                        _player2[i].transform.SetParent(HandPositions);
                        _player2[i].transform.position = handPositions[i].transform.position;
                    }

                    break;
                }
                case 3:
                {
                    for (int i = 0; i < _player2.Count; i++)
                    {
                        _player2[i].transform.SetParent(null);
                        _player2[i].transform.position = offHand.transform.position;
                        
                    }

                    for (int i = 0; i < _player3.Count; i++)
                    {
                        _player3[i].transform.SetParent(HandPositions);
                        _player3[i].transform.position = handPositions[i].transform.position;
                    }

                    break;
                }
                case 4:
                {
                    for (int i = 0; i < _player3.Count; i++)
                    {
                        _player3[i].transform.SetParent(null);
                        _player3[i].transform.position = offHand.transform.position;
                       
                    }

                    for (int i = 0; i < _player4.Count; i++)
                    {
                        _player4[i].transform.SetParent(HandPositions);
                        _player4[i].transform.position = handPositions[i].transform.position; 
                    }

                    break;
                }
            }
        }
        else if (gs.no_Players == 3)
        {
            switch (_currentPlayer)
            {
                case 1:
                {
                    for (int i = 0; i < _player3.Count; i++)
                    {
                        _player3[i].transform.SetParent(null);
                        _player3[i].transform.position = offHand.transform.position;
                       
                        // Debug.Log("it works");
                        // Debug.Log(_player1[0]);
                    }

                    for (int i = 0; i < _player1.Count; i++)
                    {
                        _player1[i].transform.SetParent(HandPositions);
                        _player1[i].transform.position = handPositions[i].transform.position;   
                    }

                    break;
                }
                case 2:
                {
                    for (int i = 0; i < _player2.Count; i++)
                    {
                        _player2[i].transform.SetParent(HandPositions);
                        _player2[i].transform.position = handPositions[i].transform.position;
                    }

                    for (int i = 0; i < _player1.Count; i++)
                    {
                       
                        _player1[i].transform.SetParent(null);
                        _player1[i].transform.position = offHand.transform.position; 
                    }

                    break;
                }
                case 3:
                {
                    for (int i = 0; i < _player3.Count; i++)
                    {
                       
                        _player3[i].transform.SetParent(HandPositions);
                        _player3[i].transform.position = handPositions[i].transform.position;
                    }
                    for (int i = 0; i < _player2.Count; i++)
                    {
                        _player2[i].transform.SetParent(null);
                        _player2[i].transform.position = offHand.transform.position;
                    }

                    break;
                }
            }
        }
        else if (gs.no_Players == 2)
        {
            switch (_currentPlayer)
            {
                case 1:
                {
                    for (int i = 0; i < _player2.Count; i++)
                    {
                        _player2[i].transform.SetParent(null);
                        _player2[i].transform.position = offHand.transform.position;
                    }

                    for (int i = 0; i < _player1.Count; i++)
                    {
                        
                        _player1[i].transform.SetParent(HandPositions);
                        _player1[i].transform.position = handPositions[i].transform.position;
                    }

                    break;
                }
                case 2:
                {
                    for (int i = 0; i < _player1.Count; i++)
                    {
                        _player1[i].transform.SetParent(null);
                        _player1[i].transform.position = offHand.transform.position;
                    }

                    for (int i = 0; i < _player2.Count; i++)
                    {
                        _player2[i].transform.SetParent(HandPositions);
                        _player2[i].transform.position = handPositions[i].transform.position;
                    }

                    break;
                }
            }
        }
    }
}
