using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayersTurn : MonoBehaviour
{
   
  
    public int maxActions = 3;
    public Text DisplayActions;
    public Button move;
    public Button shore;
    public Button capture;
    public Button trade;


    private int currentPlayerIndex = 0;
    private int remainingActions = 3;
    //private Player[] players;

    private void Start()
    {
        // Get references to the player objects or components
       // players = FindObjectsOfType<Player>();

        // Set the initial player's turn
        SetCurrentPlayerTurn(0);


    }

    public void NextTurn()
    {
        // Decrement the remaining actions for the current player
        remainingActions--;
        DisplayActions.text = "You have " + remainingActions.ToString() + " actions remaining.";

        // If the remaining actions reach zero, move to the next player's turn
        if (remainingActions <= 0)
        {
            currentPlayerIndex++;
            /*if (currentPlayerIndex >= players.Length)
            {
                currentPlayerIndex = 0;
            }*/
            //remainingActions = maxActions;

            // Hide the action buttons
            // SetActionButtonsActive(false);

            move.gameObject.SetActive(false);
            shore.gameObject.SetActive(false);
            capture.gameObject.SetActive(false);
            trade.gameObject.SetActive(false);
            DisplayActions.gameObject.SetActive(false);


        }

        // Set the turn for the new current player
        SetCurrentPlayerTurn(currentPlayerIndex);
    }

    private void SetCurrentPlayerTurn(int playerIndex)
    {
        // Set the turn for the current player
        //for (int i = 0; i < players.Length; i++)
        {
            //bool isCurrentPlayer = i == playerIndex;
            // players[i].SetTurn(isCurrentPlayer);
        }

        // Show the action buttons if it's the current player's turn
        if (playerIndex == currentPlayerIndex)
        {
            move.gameObject.SetActive(true);
            shore.gameObject.SetActive(true);
            capture.gameObject.SetActive(true);
            trade.gameObject.SetActive(true);
        }

        // Invoke the turn changed event
       
    }

    
}

