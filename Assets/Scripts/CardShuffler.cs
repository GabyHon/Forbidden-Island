using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class CardShuffler : MonoBehaviour
{
    public List<GameObject> _object;
    public List<GameObject> discard;

    public void ShuffleCards()
    {
        var length = _object.Count;
        var halfLength = _object.Count / 2;
        for (var i = 0; i < halfLength; i++)
        {
            var randNumA = Random.Range(0, length);
            var randNumB = Random.Range(0, length);
            var randTileA = _object[randNumA];
            var randTileB = _object[randNumB];
            _object[randNumA] = randTileB;
            _object[randNumB] = randTileA;
        }
    }
}
