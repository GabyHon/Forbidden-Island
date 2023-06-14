using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    // should we change this to an int value?
    [SerializeField] public bool Novice, Normal, Elite, Legendary = false;
// in all of these buttons we want to switch to the game scene.
    public void NoviceButton()
    {
        Novice = true;
        Normal = false;
        Elite = false;
        Legendary = false;
        Debug.Log("Novice was chosen");
    }

    public void NormalButton()
    {
        Novice = false;
        Normal = true;
        Elite = false;
        Legendary = false;
        Debug.Log("Normal was chosen");
    }

    public void EliteButton()
    {
        Novice = false;
        Normal = false;
        Elite = true;
        Legendary = false;
        Debug.Log("Elite was chosen");
    }

    public void LegendaryButton()
    {
        Novice = false;
        Normal = false;
        Elite = false;
        Legendary = true;
        Debug.Log("Legendary was chosen");
    }

    public void DifficultyBackButton()
    {
        Novice = false;
        Normal = false;
        Elite = false; 
        Legendary = false;
    }
}
