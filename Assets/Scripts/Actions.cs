
using Scripts;
using UnityEngine;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    private bool move = false;
    private bool shoreUp = false;
    public bool treasure = false;
    private bool capture = false;
    private bool pilotAbility = false;
    private bool navigatorAbility;
    public int actions = 0;
    public bool _actions;
    [SerializeField] private PlayeHand ph;
    [SerializeField] private GameManager gm;
    [SerializeField] private Button pilotAction;
    [SerializeField] private Button moveButton;
    [SerializeField] private Button shoreUpButton;
    [SerializeField] private Button treasureButton;
    [SerializeField] private Button captureButton;
    [SerializeField] private GameObject offHand;
    [SerializeField] private GameObject floodPlacement;
    [SerializeField] private CardShuffler treasureDeck;
    [SerializeField] private CardShuffler floodDeck;
    [SerializeField] private CardShuffler tiles;
    [SerializeField] private PilotMove pilotMove;
    [SerializeField] private DiverMove diverMove;
    [SerializeField] private MessengerMove messengerMove;
    [SerializeField] private EngineerMove engineerMove;
    [SerializeField] private NavigatorMove navigatorMove;
    public void PilotAbility()
    {
        pilotAbility = true;
    }
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
                            diverMove.gm = gm;
                            diverMove.ph = ph;
                            diverMove.o = o;
                            diverMove.currentPlayer = currentPlayer;
                            diverMove.MoveDiver();
                            if (_actions)
                            {
                                actions++;
                                _actions = false;
                            }
                            break;
                        }
                        case "Pilot":
                        {
                            pilotMove.pilotAction = pilotAction;
                            pilotMove.moveButton = moveButton;
                            pilotMove.shoreUpButton = shoreUpButton;
                                pilotMove.treasureButton = treasureButton;
                                pilotMove.captureButton = captureButton;
                                pilotMove.pilotAbility = pilotAbility;
                                pilotMove.gm = gm;
                                pilotMove.ph = ph;
                                pilotMove.o = o;
                                pilotMove.currentPlayer = currentPlayer;
                                pilotMove.MovePilot();
                                if (_actions)
                                {
                                    actions++;
                                    _actions = false;
                                }
                            break;
                        }
                        case "Explorer":// still to do
                        {
                            diverMove.gm = gm;
                            diverMove.ph = ph;
                            diverMove.o = o;
                            diverMove.currentPlayer = currentPlayer;
                            diverMove.MoveDiver();
                            if (_actions)
                            {
                                actions++;
                                _actions = false;
                            }
                            break;
                        }
                        case "Messenger":
                        {
                            messengerMove.gm = gm;
                            messengerMove.ph = ph;
                            messengerMove.o = o;
                            messengerMove.currentPlayer = currentPlayer;
                            messengerMove.MoveMessenger();
                            if (_actions)
                            {
                                actions++;
                                _actions = false;
                            }
                            break;
                        }
                        case "Engineer":
                        {
                            engineerMove.gm = gm;
                            engineerMove.ph = ph;
                            engineerMove.o = o;
                            engineerMove.currentPlayer = currentPlayer;
                            engineerMove.MoveEngineer();
                            if (_actions)
                            {
                                actions++;
                                _actions = false;
                            }
                            break;
                        }
                        case "Navigator":// still to do
                        {
                            navigatorMove.gm = gm;
                            navigatorMove.ph = ph;
                            navigatorMove.o = o;
                            navigatorMove.currentPlayer = currentPlayer;
                            navigatorMove.navigatorAbility = navigatorAbility;
                            navigatorMove.MoveNavigator();
                            if (_actions)
                            {
                                actions++;
                                _actions = false;
                            }
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
            var position = offHand.transform.position;
            var floodCard1 = floodDeck._object[0];
            var floodCard2 = floodDeck._object[1];
            var floodCard3 = floodDeck._object[2];
            var floodCard4 = floodDeck._object[3];
            var floodCard5 = floodDeck._object[4];

            if (gm.difficulty < 2)
            {
                floodCard1.transform.position = floodPlacement.transform.position; 
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard2.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                    }
                }
                // wait
                floodCard1.transform.position = position;
                floodCard2.transform.position = floodPlacement.transform.position;
                // wait
                floodCard2.transform.position = position;
            }
            else if (gm.difficulty < 5)
            {
                floodCard1.transform.position = floodPlacement.transform.position; 
                new WaitForSeconds(2f);
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard1.name)
                    {
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                    }
                }
                floodCard1.transform.position = offHand.transform.position;
                floodCard2.transform.position = floodPlacement.transform.position;
                new WaitForSeconds(2f);
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard2.name)
                    {
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                    }
                }
                floodCard2.transform.position = offHand.transform.position;
                new WaitForSeconds(2f);
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard3.name)
                    {
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                    }
                }
                floodCard3.transform.position = floodPlacement.transform.position;
                new WaitForSeconds(2f);
                floodCard1.transform.position = position;
            }
            
            ph._currentPlayer++;
            actions = 0;
        }
    }
}