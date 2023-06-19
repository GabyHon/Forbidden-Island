using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    public List<SpecialAbility> specialAbilities;
    public Button ShoreUp;
    public Button moveOtherPlayers;

    // Add any additional character-specific properties or methods here



    public enum SpecialAbility
    {
        Engineer,
        Pilot,
        Navigator,
        Messenger,
        Diver,
        Explorer,


    }

    public void PerformAbility(int abilityIndex)
    {
        if (abilityIndex >= 0 && abilityIndex < specialAbilities.Count)
        {
            SpecialAbility ability = specialAbilities[abilityIndex];
            // Perform logic based on the selected ability
            switch (ability)
            {
                case SpecialAbility.Engineer:
                    ShoreUp.gameObject.SetActive(true);
                    moveOtherPlayers.gameObject.SetActive(false);
                    break;
                case SpecialAbility.Explorer:
                    ShoreUp.gameObject.SetActive(false);
                    moveOtherPlayers.gameObject.SetActive(false);
                    break;
                case SpecialAbility.Navigator:
                    ShoreUp.gameObject.SetActive(false);
                    moveOtherPlayers.gameObject.SetActive(true);
                    break;
                case SpecialAbility.Pilot:
                    ShoreUp.gameObject.SetActive(false);
                    moveOtherPlayers.gameObject.SetActive(false);
                    break;
                case SpecialAbility.Diver:
                    ShoreUp.gameObject.SetActive(false);
                    moveOtherPlayers.gameObject.SetActive(false);
                    break;
                case SpecialAbility.Messenger:
                    ShoreUp.gameObject.SetActive(false);
                    moveOtherPlayers.gameObject.SetActive(false);
                    break;

                default:
                    Debug.LogWarning("Unknown ability selected");
                    break;
            }
        }
        else
        {
            Debug.LogError("Invalid ability index");
        }

    }

    public Guid PlayerID;

    private void Awake()
    {
        PlayerID = Guid.NewGuid();
    }

    public void SetPlayerID(Guid id)
    {
        PlayerID = id;
    }

    public Guid GetPlayerID()
    {
        return PlayerID;
    }




}