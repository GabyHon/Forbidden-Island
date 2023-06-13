using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour

{
    [SerializeField] private GameObject[] tiles;
    [SerializeField] private GameObject[] boardPositions;
    [SerializeField] public List<GameObject> treasureCards;
    [SerializeField] private List<GameObject> floodCards;
    [SerializeField] private List<GameObject> treasures;
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] playerCards;
    [SerializeField] private GameObject tileShuffler;
    [SerializeField] private GameObject tileSorter;
    [SerializeField] private GameObject treasureDeck;
    [SerializeField] private GameObject floodDeck;
    [SerializeField] private GameObject playerSorter;
    private GameObject[] treasureCardsCopy;

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
        
    }
}
