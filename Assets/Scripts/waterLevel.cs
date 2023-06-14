using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterLevel : MonoBehaviour
{
    // change to 1 marker, place the place holder gae objects into an array and use the current level to reference
    // that array, then move the marker to the position of its allocated placeholder in the array.
    public int Waterlvl; // i want to check if i can read this value when we change scenes.
    private int MaxWaterLvl = 10;
// would negate the need for this
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
    {// instead of SetActive we would use 'transform.position'
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

    public void BackButtonMarkersReset()
    {
        NoviceMarker.SetActive(false);
        NormalMarker.SetActive(false);
        EliteMarker.SetActive(false);
        LegendaryMarker.SetActive(false);
    }

    void Start()
    {
        //LevelChecker();

        /*Debug.Log("Novice was chosen, setting the marker at the first line");*/
        
        // checking if the water level has reached the skull and crossbones, line 10 of the water level card
        // can be moved to another script for the end conditions
        
        // should this not be in update or in a function that is called when the water level increases?
        if (Waterlvl == MaxWaterLvl)
        {
            Debug.Log("Game Over");
        }
    }

    public void LevelChecker()
    {// im assuming this was to test if they were working?
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
