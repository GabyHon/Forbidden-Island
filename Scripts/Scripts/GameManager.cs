using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] characters; // Array of character prefabs
    public Button[] actionButtons; // Array of action buttons
    public Text remainingActionsText; // Text component to display remaining actions
    public Text playerIndexText; // Text component to display current player index
    public Text playerNameText; // Text component to display current player name
    public Text playerAbilityText; // Text component to display current player ability

    private int numberOfPlayers;
    public List<GameObject> players = new List<GameObject>();
    private List<int> assignedCharacters; // Stores the assigned character indices for each player
    private int currentPlayerIndex;
    private int remainingActions;

    private void Start()
    {
        // Get the number of players from user input
        numberOfPlayers = GetNumberOfPlayers();

        // Assign characters to players
        AssignCharacters();

        // Set the initial player's turn
        currentPlayerIndex = 0;
        remainingActions = 3;
        remainingActionsText.text = "Remaining actions: " + remainingActions.ToString();
        SetCurrentPlayerTurn(currentPlayerIndex);
    }

    private int GetNumberOfPlayers()
    {
        // Replace this with your own logic to get the number of players from user input
        return 4;
    }

    private void AssignCharacters()
    {
        // Randomly assign characters to players
        assignedCharacters = new List<int>();

        for (int i = 0; i < numberOfPlayers; i++)
        {
            int randomIndex = Random.Range(0, characters.Length);

            // Check if the character has already been assigned
            while (assignedCharacters.Contains(randomIndex))
            {
                randomIndex = Random.Range(0, characters.Length);
            }

            assignedCharacters.Add(randomIndex);
        }

        // Instantiate player objects with assigned characters
        for (int i = 0; i < numberOfPlayers; i++)
        {
            GameObject player = Instantiate(characters[assignedCharacters[i]]);
            player.SetActive(false);
            players.Add(player);
        }
    }

    private void SetCurrentPlayerTurn(int playerIndex)
    {
        // Deactivate all players
        foreach (GameObject player in players)
        {
            player.SetActive(false);

        }

        // Activate the current player
        GameObject currentPlayer = players[playerIndex];
        GameObject currentCharacter = characters[playerIndex];
        currentPlayer.SetActive(true);

        // Get the character index for the current player
        int characterIndex = playerIndex % characters.Length;

        // Instantiate the character prefab and set it as the player's character
        GameObject characterPrefab = characters[characterIndex];
        GameObject characterInstance = Instantiate(characterPrefab, currentPlayer.transform);
        characterInstance.transform.localPosition = Vector3.zero;
        Character currentPlayerCharacter = currentPlayer.GetComponent<Character>();

        // Get the Character component of the current player
        Character character = characterInstance.GetComponent<Character>();
        PlayerID playerID = currentPlayer.GetComponent<PlayerID>();

        // Update UI with current player's information
        playerIndexText.text = playerIndex.ToString();
        playerNameText.text = playerID.PlayerName;
        playerAbilityText.text = character.name;

        if (playerIndex == playerID.id)
        {
            playerID.isCurrentPlayer = true;
        }
        else
            playerID.isCurrentPlayer = false;

        // Show the action buttons for the current player
        SetActionButtonsActive(true);


    }

    private void SetActionButtonsActive(bool isActive)
    {
        foreach (Button button in actionButtons)
        {
            button.gameObject.SetActive(isActive);
        }
    }

    public void PerformAction()
    {
        // Decrease the remaining actions count
        remainingActions--;

        // Update UI with remaining actions
        remainingActionsText.text = "Remaining Actions: " + remainingActions;

        // Check if remaining actions are exhausted
        if (remainingActions == 0)
        {
            // Hide the action buttons
            SetActionButtonsActive(false);



            // Move to the next player's turn
            StartCoroutine(NextTurnCoroutine());
        }
    }

    private IEnumerator NextTurnCoroutine()
    {
        yield return new WaitForSeconds(2f); // Add a delay before moving to the next player's turn

        currentPlayerIndex++;
        playerIndexText.text = currentPlayerIndex.ToString();

        // Check if all players have played and restart from the first player
        if (currentPlayerIndex > 3)
        {
            currentPlayerIndex = 0;
            playerIndexText.text = currentPlayerIndex.ToString();

        }

        remainingActions = 3;
        remainingActionsText.text = "Remaining actions: " + remainingActions.ToString();

        GameObject currentPlayer = players[currentPlayerIndex];


        PlayerID playerID = currentPlayer.GetComponent<PlayerID>();


        //playerNameText.text = playerID.PlayerName;




        if (currentPlayerIndex == playerID.id)
        {
            playerID.isCurrentPlayer = true;
        }
        else
            playerID.isCurrentPlayer = false;



        foreach (GameObject player in players)
        {
            player.SetActive(false);
        }

        // Activate the current player
        currentPlayer.SetActive(true);

        // Check if all players have played and restart from the first player
        if (currentPlayerIndex >= players.Count)
        {
            currentPlayerIndex = 0;
        }

        SetCurrentPlayerTurn(currentPlayerIndex);
    }
}

