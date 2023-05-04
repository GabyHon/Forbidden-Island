using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterLevel : MonoBehaviour
{
    private int Waterlvl;
    private int MaxWaterLvl = 10;

    private int NoviceLvl = 1;
    private int NormalLvl = 2;
    private int EliteLvl = 3;
    private int LegendaryLvl = 4;

    [SerializeField] private GameObject WaterMarker;

    void Start()
    {
        LevelChecker();
        
        // checking if the water level has reached the skull and crossbones, line 10 of the water level card
        // can be moved to another script for the end conditions
        if (Waterlvl == MaxWaterLvl)
        {
            Debug.Log("Game Over");
        }
    }

    public void LevelChecker()
    {
        if (Waterlvl == NoviceLvl)
        {
            Debug.Log("Starting at novice level");
        }
        else if (Waterlvl == NormalLvl)
        {
            Debug.Log("Starting at normal level");
        }
        else if (Waterlvl == EliteLvl)
        {
            Debug.Log("Starting at elite level");
        }
        else if (Waterlvl == LegendaryLvl)
        {
            Debug.Log("Starting at legendary level");
        }
        else
        {
            Debug.Log("No starting level chosen");
        }
    }
}
