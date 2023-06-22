
using UnityEngine;

public class Actions : MonoBehaviour
{
    private bool _move = false;
    private bool shoreUp = false;
    public bool treasure = false;
    private bool capture = false;
    public int actions = 0;
    [SerializeField] private PlayeHand ph;
    [SerializeField] private GameManager gm;
    
    public void Move()
    {
        _move = true;
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

        if (_move)
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
                            Debug.Log(hit.collider.tag);
                            if (currentPlayer.transform.parent.name == gm.boardPositions[0].name)
                            {
                                Debug.Log("pos1");
                                if (o.transform.parent.name == gm.boardPositions[1].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name 
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false) && (gm.flooded[14] 
                                             || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;  
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
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
                                if (o.transform.parent.name == gm.boardPositions[0].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false) && (gm.flooded[9] 
                                             || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false) && (gm.flooded[9]
                                             || gm.boardPositions[9].active == false) && (gm.flooded[15] 
                                             || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;  
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false) && (gm.flooded[9] 
                                             || gm.boardPositions[9].active == false) && (gm.flooded[15] 
                                             || gm.boardPositions[15].active == false)&& (gm.flooded[20] 
                                             || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;  
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[2].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name && gm.flooded[3])
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false)
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[3].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[4].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[1].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[5].name)
                            {
                                 if (o.transform.parent.name == gm.boardPositions[10].name)
                                 {
                                     gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                     gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                     actions++; 
                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[16].name
                                          && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                 {
                                     gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                     gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                     actions++; 
                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[21].name
                                          && (gm.flooded[10] || gm.boardPositions[10].active == false)
                                          && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                 {
                                     gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                     gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                     actions++; 
                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[4].name)
                                 {
                                     gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                     gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                     actions++; 
                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[3].name
                                          && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                 {
                                     gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                     gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                     actions++; 
                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[2].name
                                          && (gm.flooded[4] || gm.boardPositions[4].active == false)
                                          && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                 {
                                     gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                     gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                     actions++; 
                                 }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[6].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[7].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[2].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[13].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[6].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[8].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[9].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[4].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[10].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[5].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[11].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[17].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[12].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[6].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[13].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[14].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[8].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[3].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[15].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[9].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[16].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[10].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[17].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[11].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                    && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[18].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[13].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }else if (o.transform.parent.name == gm.boardPositions[2].name
                                          && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                          && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[19].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[20].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[15].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[21].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[16].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[22].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[23].name)
                            {
                                 if (o.transform.parent.name == gm.boardPositions[20].name) 
                                 {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name)
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                }
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
                            Debug.Log("engineer");
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
                _move = false;
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