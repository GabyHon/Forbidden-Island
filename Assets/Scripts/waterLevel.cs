using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterLevel : MonoBehaviour
{
    private int Waterlvl;
    private int MaxWaterLvl = 10;

    private int NoviceLvl = 1;
    private int NormalLvl = 2;
    private int EliteLvl = 3;
    private int LegendaryLvl = 4;

    [Header("Novice")]
    [SerializeField] private GameObject NoviceMarker;
    [SerializeField] private GameObject NoviceMarkerHolder;

    [Header("Normal")]
    [SerializeField] private GameObject NormalMarker;
    [SerializeField] private GameObject NormalMarkerHolder;

    [Header("Elite")]
    [SerializeField] private GameObject EliteMarker;
    [SerializeField] private GameObject EliteMarkerHolder;

    [Header("Legendary")]
    [SerializeField] private GameObject LegendaryMarker;
    [SerializeField] private GameObject LegendaryMarkerHolder;

    public void SettingNoviceMarkerToActive()
    {
        NoviceMarker.transform.position = NoviceMarkerHolder.transform.position;
        NoviceMarker.SetActive(true);
        NormalMarker.SetActive(false);
        EliteMarker.SetActive(false);
        LegendaryMarker.SetActive(false);
    }
    
    public void SettingNormalMarkerToActive()
    {
        NormalMarker.transform.position = NormalMarkerHolder.transform.position;
        NoviceMarker.SetActive(false);
        NormalMarker.SetActive(true);
        EliteMarker.SetActive(false);
        LegendaryMarker.SetActive(false);
    }

    public void SettingEliteMarkerToActive()
    {
        EliteMarker.transform.position = EliteMarkerHolder.transform.position;
        NoviceMarker.SetActive(false);
        NormalMarker.SetActive(false);
        EliteMarker.SetActive(true);
        LegendaryMarker.SetActive(false);
    }

    public void SettingLegendaryMarkerToActive()
    {
        LegendaryMarker.transform.position = LegendaryMarkerHolder.transform.position;
        NoviceMarker.SetActive(false);
        NormalMarker.SetActive(false);
        EliteMarker.SetActive(false);
        LegendaryMarker.SetActive(true);
    }

    void Start()
    {
        //LevelChecker();

        /*Debug.Log("Novice was chosen, setting the marker at the first line");*/
        
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
