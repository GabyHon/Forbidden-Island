using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    [SerializeField] public bool Novice, Normal, Elite, Legendary = false;

    public void NoiceButton()
    {
        Novice = true;
        Debug.Log("Novice was chosen");
    }

    public void NormalButton()
    {
        Normal = true;
        Debug.Log("Normal was chosen");
    }

    public void EliteButton()
    {
        Elite = true;
        Debug.Log("Elite was chosen");
    }

    public void LegendaryButton()
    {
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
