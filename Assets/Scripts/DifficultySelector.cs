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

    public bool Novice = false;
    public bool Normal = false;
    public bool Elite = false;
    public bool Legendary = false;

    void Update()
    {
        switch (difficulty)
        {
            case DifficultyChosen.Select:
                Novice = false;
                Normal = false;
                Elite = false;
                Legendary = false;
                print("Please select a difficulty");
                break;
            case DifficultyChosen.Novice:
                Novice = true;
                Normal = false;
                Elite = false;
                Legendary = false;
                print("Novice was chosen");
                break;
            case DifficultyChosen.Normal:
                Novice = false;
                Normal = true;
                Elite = false;
                Legendary = false;
                print("Normal was chosen");
                break;
            case DifficultyChosen.Elite:
                Novice = false;
                Normal = false;
                Elite = true;
                Legendary = false;
                print("Elite was chosen");
                break;
            case DifficultyChosen.Legenary:
                Novice = false;
                Normal = false;
                Elite = false;
                Legendary = true;
                print("Legendary was chosen");
                break;
        }
    }
}
