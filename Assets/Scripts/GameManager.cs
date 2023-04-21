using System;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour

{
    [SerializeField] private GameObject[] tiles;
    [SerializeField] private GameObject[] boardPositions;
    [SerializeField] private GameObject[] treasureCards;
    [SerializeField] private GameObject[] floodCards;
    [SerializeField] private GameObject[] treasures;
    [SerializeField] private GameObject[] players;
    [SerializeField] private GameObject[] playerCards;
    [SerializeField] private GameObject tileShuffler;
    [SerializeField] private GameObject tileSorter;
    [SerializeField] private GameObject treasureDeck;
    [SerializeField] private GameObject floodDeck;
    [SerializeField] private GameObject playerSorter;

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
        treasureShuffler._object = treasureCards;
        treasureShuffler.ShuffleCards();
        var floodShuffler = floodDeck.GetComponent<CardShuffler>();
        floodShuffler._object = floodCards;
        floodShuffler.ShuffleCards();
        var _playerSorter = playerSorter.GetComponent<PlayerSorter>();
        _playerSorter._object = playerCards;
        _playerSorter.player = players;
        _playerSorter.SortCards();
    }
}
