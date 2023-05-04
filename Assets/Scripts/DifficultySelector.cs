using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public enum DifficultyChosen
    {
        Select, Novice, Normal, Elite, Legenary
    }

    public DifficultyChosen difficulty;

    // Update is called once per frame
    void Update()
    {
        switch (difficulty)
        {
            case DifficultyChosen.Select:
                print("Please select a difficulty");
                break;
            case DifficultyChosen.Novice:
                print("Novice was chosen");
                break;
            case DifficultyChosen.Normal:
                print("Normal was chosen");
                break;
            case DifficultyChosen.Elite:
                print("Elite was chosen");
                break;
            case DifficultyChosen.Legenary:
                print("Legendary was chosen");
                break;
        }
    }
}
