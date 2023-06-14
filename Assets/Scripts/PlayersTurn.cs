using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayersTurn : MonoBehaviour
{
    bool ActionsTaken = false;
    bool TreasureCardsDrawn = false;
    bool FloodCardsDrawn = false;
    bool isPlayerTurn = true;
    int currentPlayer = 1;

    /*public CompleteActions completeActions;
    public DrawTCards drawTCards;
    public DrawFCards drawFCards;*/

    void start()
    {
        BeginPlayersTurn();

        /*TreasureCardsDrawn = DrawTCards.treasureCardsDrawn;
        ActionsTaken = CompleteActions.actionsTaken;
        FloodCardsDrawn = DrawFCards.floodCardsDrawn;*/

    }
    
       

    

    void Update()
    {
        if (isPlayerTurn)
        {
            if ((ActionsTaken = false) && (TreasureCardsDrawn = false) && (FloodCardsDrawn = false))
            {
                currentPlayer = 1;
                Debug.Log("Player 1");
            }
        }
    }


    void BeginPlayersTurn()
    {
        Debug.Log("It's now the player's turn");
        isPlayerTurn = true;
    }

    void EndPlayersTurn()
    {
        if ((ActionsTaken = true) && (TreasureCardsDrawn = true) && (FloodCardsDrawn = true))
        {
            Debug.Log("Player's turn has ended");
            isPlayerTurn = false;
            currentPlayer = currentPlayer + 1;

        }
    }


    public void EndTurn()
    {
        if (currentPlayer == 1)
        {
            currentPlayer = 2;
        }
        else
        {
            currentPlayer = 1;
        }

    }
   







}
