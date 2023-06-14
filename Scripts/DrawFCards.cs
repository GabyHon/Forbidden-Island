using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DrawFCards : MonoBehaviour, IPointerClickHandler
    {
    public Button floodButton;
        bool floodCardsDrawn = false;
        int drawnCard = 0;
        int WaterLevel = 2;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (drawnCard > WaterLevel)
        {
            Debug.Log("Draw Flood card");
            WaterLevel = WaterLevel - 1;
        }
        else
        {
            floodButton.gameObject.SetActive(false);
            floodCardsDrawn = true;
        }

    } 
}