using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSorter : MonoBehaviour
{
    public GameObject[] _object;
    public GameObject[] player;

        public void SortCards()
    {
        var length = _object.Length;
        var halfLength = _object.Length / 2;
        for (var i = 0; i < halfLength; i++)
        {
            var randNumA = Random.Range(0, length);
            var randNumB = Random.Range(0, length);
            var randTileA = _object[randNumA];
            var randTileB = _object[randNumB];
            var randPlayerA = player[randNumA];
            var randPlayerB = player[randNumB];
            _object[randNumA] = randTileB;
            player[randNumA] = randPlayerB;
            _object[randNumB] = randTileA;
            player[randNumB] = randPlayerA;
        }
    }
}
