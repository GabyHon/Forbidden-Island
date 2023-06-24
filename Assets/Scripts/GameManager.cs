using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour

{
    public List<GameObject> tiles;
    public GameObject[] boardPositions;
    public bool[] flooded;
    public List<GameObject> treasureCards;
    [SerializeField] private List<GameObject> floodCards;
    [SerializeField] private List<GameObject> treasures;
    public GameObject[] players;
    [SerializeField] private GameObject[] playerCards;
    [SerializeField] private GameObject[] levelPos;
    [SerializeField] private GameObject tileShuffler;
    [SerializeField] private GameObject levelMarker;
    [SerializeField] private GameObject tileSorter;
    [SerializeField] private GameObject treasureDeck;
    [SerializeField] private GameObject floodDeck;
    [SerializeField] private GameObject playerSorter;
    [SerializeField] private GameObject diverPos;
    [SerializeField] private GameObject navigatorPos;
    [SerializeField] private GameObject pilotPos;
    [SerializeField] private GameObject explorerPos;
    [SerializeField] private GameObject messengerPos;
    [SerializeField] private GameObject engineerPos;
    [SerializeField] private GameSystem gs;
    private GameObject[] treasureCardsCopy;
    public bool treasreShuffle = false;
    public int difficulty;
    

    public void Start()
    {
        var _shuffler = tileShuffler.GetComponent<CardShuffler>();
        _shuffler._object = tiles;
        _shuffler.ShuffleCards();
        var _sorter = tileSorter.GetComponent<TileSorter>();
        _sorter.positions = boardPositions;
        _sorter.tiles = tiles;
        _sorter.Tile_Sorter();
        var treasureShuffler = treasureDeck.GetComponent<CardShuffler>();
        for (int i = 0; i < treasureCards.Count; i++)
        {
            treasureShuffler._object[i] = treasureCards[i];
        }
        treasureShuffler.ShuffleCards();
        treasreShuffle = true;
        var floodShuffler = floodDeck.GetComponent<CardShuffler>();
        for (int i = 0; i < floodCards.Count; i++)
        {
            floodShuffler._object[i] = floodCards[i];
        }
        floodShuffler.ShuffleCards();
        var _playerSorter = playerSorter.GetComponent<PlayerSorter>();
        _playerSorter._object = playerCards;
        _playerSorter.player = players;
        _playerSorter.SortCards();
        if (_playerSorter.sorted)
        {Debug.Log(players.Length);
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].CompareTag("Diver"))
                {
                    players[i].transform.position = diverPos.transform.position;
                    players[i].transform.parent = diverPos.transform.parent;
                }
                if (players[i].CompareTag("Engineer"))
                {
                    players[i].transform.position = engineerPos.transform.position;
                    players[i].transform.parent = engineerPos.transform.parent;
                }
                if (players[i].CompareTag("Explorer"))
                {
                    players[i].transform.position = explorerPos.transform.position;
                    players[i].transform.parent = explorerPos.transform.parent;
                }
                if (players[i].CompareTag("Pilot"))
                {
                    players[i].transform.position = pilotPos.transform.position;
                    players[i].transform.parent = pilotPos.transform.parent;
                }
                if (players[i].CompareTag("Messenger"))
                {
                    players[i].transform.position = messengerPos.transform.position;
                    players[i].transform.parent = messengerPos.transform.parent;
                }
                if (players[i].CompareTag("Navigator"))
                {
                    players[i].transform.position = navigatorPos.transform.position;
                    players[i].transform.parent = navigatorPos.transform.parent;
                }
                else if (i == players.Length)
                {

                    _playerSorter.sorted = false;
                }
            }
        }

        difficulty = gs.startingDifficulty;
    }

    private void Update()
    {
        levelMarker.transform.position = levelPos[difficulty].transform.position;
    }
}
