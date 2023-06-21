using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Actions : MonoBehaviour
{
    private bool move = false;
    private bool shoreUp = false;
    public bool treasure = false;
    private bool capture = false;
    public int actions = 0;
    [SerializeField] private PlayeHand ph;
    [SerializeField] private GameManager gm;
    
    public void Move()
    {
        move = true;
    }

    public void ShoreUp()
    {
        shoreUp = true;
    }

    public void Treasure()
    {
        treasure = true;
    }

    public void Capture()
    {
        capture = true;
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        //Debug.Log(mousePos);

        if (move)
        {
            //make action buttons inactive
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("move");
                //raycast, get collider and if the collider's tag is 'tile' then 
                //get the current player's piece and the piece's parent, then check
                //if the colliders parent is one of the tiles the player can move to 
                //from the tile they are on now, taking into account the player's
                //ability. then if it is add 1 to actions, move the player to the®
                //colliders parent and parent the player to the colliders parent
                // and change move to false, lastly making the buttons active again
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);

                if (hit.collider.gameObject.CompareTag("Tile"))
                {
                    var o = hit.collider.gameObject;
                    var currentPlayer = gm.players[ph._currentPlayer - 1];
                    switch (gm.players[ph._currentPlayer - 1].tag)
                    {
                        case "Diver":
                        {
                            if (currentPlayer.transform.parent.name == gm.boardPositions[0].name)
                            {
                                Debug.Log("pos1");
                                if (o.transform.parent.name == gm.boardPositions[1].name && gm.flooded[1] == false)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name && gm.flooded[3] == false)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name && gm.flooded[8] == false 
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name && gm.flooded[14] == false
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name && gm.flooded[19] == false
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false) && (gm.flooded[14] 
                                             || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;  
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name && gm.flooded[22] == false
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false) && (gm.flooded[14] 
                                             || gm.boardPositions[14].active == false)&& (gm.flooded[19] 
                                             || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;  
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[1].name)
                            {
                                
                            }
                            Debug.Log("Diver");
                            break;
                        }
                        case "Pilot":
                        {
                            Debug.Log("pilot");
                            actions++;
                            break;
                        }
                        case "Explorer":
                        {
                            Debug.Log("explorer");
                            actions++;
                            break;
                        }
                        case "Messenger":
                        {
                            Debug.Log("messenger");
                            actions++;
                            break;
                        }
                        case "Engineer":
                        {
                            Debug.Log("engeneer");
                            actions++;
                            break;
                        }
                        case "Navigator":
                        {
                            Debug.Log("navigator");
                            actions++;
                            break;
                        }
                    }
                }
                Debug.Log(hit.transform.gameObject.transform.parent);
                move = false;
            }
        }
        if (shoreUp)
        {
            //make action buttons inactive
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("shore up");
                //raycast, get collider and if the collider's tag is 'tile' then 
                //get the current player's piece and the piece's parent, then check
                //if the colliders parent is one of the tiles the player is next to
                //, taking into account the player's
                //ability. then if it is add 1 to actions, shore up the tile
                // and change shoreUp to false, lastly making the buttons active again
            }
        } 
        if (treasure)
        {
            //make action buttons inactive
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("treasure");
                //raycast, get the colliders tag, if the tag is treasureCard, make all
                //the player buttons active that are parented to the same position, in
                //that button script cet the card from this script and add it to the
                //list of treasure cards of the player recieving it, make the player
                //buttons inactive, make the action buttons active and add 1 to actions
            }
        }
        if (capture)
        {
            //check
        }

        if (actions == 3)
        {
            ph._currentPlayer++;
            actions = 0;
        }
    }
}
