using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBetweenTiles : MonoBehaviour
{
    [Header("Top Boarders")]
    [SerializeField] GameObject BoardRestrictionOne;
    [SerializeField] GameObject BoardRestrictionTwo;
    [SerializeField] GameObject BoardRestrictionThree;
    [SerializeField] GameObject BoardRestrictionFour;
    [SerializeField] GameObject BoardRestrictionFive;
    [SerializeField] GameObject BoardRestrictionSix;

    [Header("Player Pieces")]
    [SerializeField] GameObject DiverPlayerPiece;
    [SerializeField] GameObject PilotPlayerPiece;
    [SerializeField] GameObject ExplorerPlayerPiece;
    [SerializeField] GameObject MessengerPlayerPiece;
    [SerializeField] GameObject EngineerPlayerPiece;
    [SerializeField] GameObject NavigatorPlayerPiece;

    /*[Header("Starting player token positions")]
    [SerializeField] GameObject BronzeGate;
    [SerializeField] GameObject CopperGate;
    [SerializeField] GameObject FoolsLanding;
    [SerializeField] GameObject GoldenGate;
    [SerializeField] GameObject IronGate;
    [SerializeField] GameObject SilverGate;*/


    /*private void Start()
    {
        EngineerPlayerPiece.transform.position = BronzeGate.transform.position;
        ExplorerPlayerPiece.transform.position = CopperGate.transform.position;
        PilotPlayerPiece.transform.position = FoolsLanding.transform.position;
        NavigatorPlayerPiece.transform.position = GoldenGate.transform.position;
        DiverPlayerPiece.transform.position = IronGate.transform.position;
        MessengerPlayerPiece.transform.position = SilverGate.transform.position;
    }*/

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            EngineerPlayerPiece.transform.Translate(0, 2, 0);
            //Debug.Log("Up arrow was pressed");

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
            EngineerPlayerPiece.transform.Translate(0, -2, 0);
            //Debug.Log("Down arrow was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            EngineerPlayerPiece.transform.Translate(-2, 0, 0);
            //Debug.Log("Left arrow was pressed");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            EngineerPlayerPiece.transform.Translate(2, 0, 0);
            //Debug.Log("Right arrow was pressed");
        }
    }
}
