using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CompleteActions : MonoBehaviour, IPointerClickHandler

{
    public Button actionButton;
    bool actionsTaken = false;
    public void OnPointerClick(PointerEventData eventData)
    {
     
     actionButton.gameObject.SetActive(false);
     actionsTaken = true;
       

    }


}
