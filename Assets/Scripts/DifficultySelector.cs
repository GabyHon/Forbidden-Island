using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public enum DifficultyChosen
    {
        Novice, Normal, Elite, Legenary
    }

    public DifficultyChosen difficulty;

    // Update is called once per frame
    void Update()
    {
        switch (difficulty)
        {
            case DifficultyChosen.Novice:
                print("Novice level was chosen");
                break;
            case DifficultyChosen.Normal:
                print("Normal level was chosen");
                break;
            case DifficultyChosen.Elite:
                print("Elite level was chosen");
                break;
            case DifficultyChosen.Legenary:
                print("Legendary level was chosen");
                break;
        }
    }
}
