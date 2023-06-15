using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBetweenTiles : MonoBehaviour
{
    [SerializeField] GameObject BoardRestrictionOne;
    [SerializeField] GameObject BoardRestrictionTwo;
    [SerializeField] GameObject BoardRestrictionThree;
    [SerializeField] GameObject BoardRestrictionFour;
    [SerializeField] GameObject BoardRestrictionFive;
    [SerializeField] GameObject BoardRestrictionSix;
    [SerializeField] GameObject PlayerPiece;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 2, 0);
            Debug.Log("Up arrow was pressed");

             /*if (PlayerPiece.transform.position == BoardRestrictionOne.transform.position 
                || PlayerPiece.transform.position == BoardRestrictionTwo.transform.position
                || PlayerPiece.transform.position == BoardRestrictionThree.transform.position
                || PlayerPiece.transform.position == BoardRestrictionFour.transform.position
                || PlayerPiece.transform.position == BoardRestrictionFive.transform.position
                || PlayerPiece.transform.position == BoardRestrictionSix.transform.position)
            {
                Input.GetKeyDown(KeyCode.UpArrow);
                Debug.Log("Cannot go past top boarder tile");
            }*/
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -2, 0);
            Debug.Log("Down arrow was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2, 0, 0);
            Debug.Log("Left arrow was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2, 0, 0);
            Debug.Log("Right arrow was pressed");
        }
    }
}
