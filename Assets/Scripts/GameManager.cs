using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour

{
    [SerializeField] private GameObject[] tiles;
    [SerializeField] private GameObject[] boardPositions;
    [SerializeField] private GameObject[] treasureCards;
    [SerializeField] private GameObject[] floodCards;
    [SerializeField] private GameObject[] treasures;
    [SerializeField] private GameObject[] players;
    public GameObject shuffler;


    public void Start()
    {
        var _shuffler = shuffler.GetComponent<CardShuffler>();
        _shuffler._object = tiles;
        _shuffler.ShuffleCards();
        FloodManager();
        TreasureCardManager();
    }
    private void FloodManager()
    {
        int maxTiles = floodCards.Length;
        int halfTiles = floodCards.Length / 2;
        for (int i = 0; i < halfTiles; i++)
        {
            int position1 = Random.Range(0, maxTiles);
            int position2 = Random.Range(0, maxTiles);
            GameObject tile1 = floodCards[position1];
            GameObject tile2 = floodCards[position2];
            floodCards[position1] = tile2;
            floodCards[position2] = tile1;
        }
    }

    private void TreasureCardManager()
    {
        int maxTiles = treasureCards.Length;
        int halfTiles = treasureCards.Length / 2;
        for (int i = 0; i < halfTiles; i++)
        {
            int position1 = Random.Range(0, maxTiles);
            int position2 = Random.Range(0, maxTiles);
            GameObject tile1 = treasureCards[position1];
            GameObject tile2 = treasureCards[position2];
            treasureCards[position1] = tile2;
            treasureCards[position2] = tile1;
        }
    }
    
}
