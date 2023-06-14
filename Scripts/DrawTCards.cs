using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DrawTCards : MonoBehaviour, IPointerClickHandler
 
{
    public Button treasureButton;
    bool treasureCardsDrawn = false;
    int drawnCard = 0;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (drawnCard < 2)
        {
            Debug.Log("Draw treasure");
            drawnCard = drawnCard + 1;
        }
        else
        {
            treasureButton.gameObject.SetActive(false);
            treasureCardsDrawn = true;
        }

    }


}
