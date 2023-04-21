using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TileSorter : MonoBehaviour
{
  public GameObject[] positions;
  public GameObject[] tiles;

  public void Tile_Sorter()
  {
    var length = tiles.Length;
    for (var i = 0; i < length; i++)
    {
      tiles[i].transform.position = positions[i].transform.position;
    }
  }
  
}
