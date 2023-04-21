using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    [SerializeField] private int difficulty = 0;

    // Update is called once per frame
    void Update()
    {
        switch (difficulty)
        {
            case 1:
                print("Novice level was chosen");
                break;
            case 2:
                print("Normal level was chosen");
                break;
            case 3:
                print("Elite level was chosen");
                break;
            case 4:
                print("Legendary level was chosen");
                break;
            default:
                print("Please choose a level");
                break;
        }
    }
}
