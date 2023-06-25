
using System.Linq;
using Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Actions : MonoBehaviour
{
    public bool move = false;
    private bool shoreUp = false;
    public bool treasure = false;
    private bool capture = false;
    private bool pilotAbility = false;
    private bool navigatorAbility;
    public int actions = 0;
    public bool _actions;
    public bool windCollected;
    public bool fireCollected;
    public bool oceanCollected;
    public bool earthCollected;
    [SerializeField] private PlayeHand ph;
    [SerializeField] private GameManager gm;
    [SerializeField] private Button pilotAction;
    [SerializeField] private Button moveButton;
    [SerializeField] private Button shoreUpButton;
    [SerializeField] private Button treasureButton;
    [SerializeField] private Button captureButton;
    [SerializeField] private Button pilotGive;
    [SerializeField] private Button diverGive;
    [SerializeField] private Button messengerGive;
    [SerializeField] private Button engineerGive;
    [SerializeField] private Button explorerGive;
    [SerializeField] private Button navigatorGive;
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
    [SerializeField] private ExplorerMove explorerMove;
    [SerializeField] private GameSystem gs;
    [SerializeField] private ShoreUpExplorer shoreUpExplorer;
    [SerializeField] private ShoreUp _shoreUp;
    private bool pilotTreasure;
    private bool navigatorTreasure;
    private bool explorerTreasure;
    private bool engineerTreasure;
    private bool diverTreasure;
    private bool messengerTreasure;
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

    public void PilotGive()
    {
        pilotTreasure = true;
    }
    public void DiverGive()
    {
        diverTreasure = true;
    }
    public void MessengerGive()
    {
        messengerTreasure = true;
    }
    public void EngineerGive()
    {
        engineerTreasure = true;
    }
    public void ExplorerGive()
    {
        explorerTreasure = true;
    }
    public void NavigatorGive()
    {
        navigatorTreasure = true;
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
                            if (pilotAbility)
                            {
                                Debug.Log("pilot ability");
                                if (Input.GetMouseButton(0))
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    pilotAbility = false;
                                    move = false;
                                    actions++;
                                }
                            }
                            else
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
                            }

                            break;
                        }
                        case "Explorer":// still to do
                        {
                            explorerMove.gm = gm;
                            explorerMove.ph = ph;
                            explorerMove.o = o;
                            explorerMove.currentPlayer = currentPlayer;
                            explorerMove.MoveExplorer();
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
            }
        }
        if (shoreUp)
        {
            //make action buttons inactive
            if (Input.GetMouseButtonDown(0))
            {
                
                Debug.Log("shore up");
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);

                if (hit.collider.gameObject.CompareTag("Tile"))
                {
                    var o = hit.collider.gameObject;
                    var currentPlayer = gm.players[ph._currentPlayer - 1];
                    if (gm.players[ph._currentPlayer - 1].CompareTag("Explorer"))
                    {
                        shoreUpExplorer.gm = gm;
                        shoreUpExplorer.ph = ph;
                        shoreUpExplorer.o = o;
                        shoreUpExplorer.currentPlayer = currentPlayer;
                        shoreUpExplorer.ShoreUp();
                        if (_actions)
                        {
                            actions++;
                            _actions = false;
                        }
                    }
                    else
                    {
                        _shoreUp.gm = gm;
                        _shoreUp.ph = ph;
                        _shoreUp.o = o;
                        _shoreUp.currentPlayer = currentPlayer;
                        _shoreUp.Shore();
                        if (_actions)
                        {
                            actions++;
                            _actions = false;
                        }
                    }
                }
            }
        } 
        if (treasure)
        {
            //make action buttons inactive
            
                    GameObject navigator = null;
                    GameObject pilot = null;
                    GameObject explorer = null;
                    GameObject engineer = null;
                    GameObject diver = null;
                    GameObject messenger = null;
                    var currentPlayer = gm.players[ph._currentPlayer - 1];
                    for (int i = 0; i < gm.players.Length; i++)
                    {
                        if (gm.players[i].name == "Pilot_Front")
                        { 
                            pilot = gm.players[i];
                        }
                        else if (gm.players[i].name == "Explorer_Front")
                        {
                            explorer = gm.players[i];
                        }
                        else if (gm.players[i].name == "Engineer_Front")
                        {
                            engineer = gm.players[i];
                        }
                        else if (gm.players[i].name == "Navigator_Front")
                        {
                            navigator = gm.players[i];
                        }
                        else if (gm.players[i].name == "Diver_Front")
                        {
                            diver = gm.players[i];
                        }
                        else if (gm.players[i].name == "Messenger_Front")
                        {
                            messenger = gm.players[i];
                        }
                    }

                    if (currentPlayer.name == "MessengerFront")
                    {
                        diverGive.gameObject.SetActive(true);
                        engineerGive.gameObject.SetActive(true);
                        pilotGive.gameObject.SetActive(true);
                        explorerGive.gameObject.SetActive(true);
                        navigatorGive.gameObject.SetActive(true);
                    }
                    else
                    {
                        if (navigator.transform.parent == currentPlayer.transform.parent)
                        {
                            navigatorGive.gameObject.SetActive(true);
                        } 
                        if (messenger.transform.parent == currentPlayer.transform.parent)
                        {
                            messengerGive.gameObject.SetActive(true);
                        } 
                        if (explorer.transform.parent == currentPlayer.transform.parent)
                        {
                            explorerGive.gameObject.SetActive(true);
                        } 
                        if (engineer.transform.parent == currentPlayer.transform.parent)
                        {
                            engineerGive.gameObject.SetActive(true);
                        } 
                        if (diver.transform.parent == currentPlayer.transform.parent)
                        {
                            diverGive.gameObject.SetActive(true);
                        } 
                        if (pilot.transform.parent == currentPlayer.transform.parent)
                        {
                            pilotGive.gameObject.SetActive(true);
                        } 
                    }

                    if (engineerTreasure)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            
                                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);
                                var give = 0;
                            for (int i = 0; i < gm.players.Length; i++)
                            {
                                if (gm.players[i].name == "Engineer_Front")
                                {
                                    give = i;
                                }
                            }

                            if (give == 1)
                            {
                                ph._player1.Add(hit.collider.gameObject);
                            }
                            else if (give == 2)
                            {
                                ph._player2.Add(hit.collider.gameObject);
                            }
                            else if (give == 3)
                            {
                                ph._player3.Add(hit.collider.gameObject);
                            }
                            else if (give == 4)
                            {
                                ph._player4.Add(hit.collider.gameObject);
                            }
                        }
                    }
                    if (pilotTreasure)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            
                            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);
                            var give = 0;
                            for (int i = 0; i < gm.players.Length; i++)
                            {
                                if (gm.players[i].name == "Pilot_Front")
                                {
                                    give = i;
                                }
                            }

                            if (give == 1)
                            {
                                ph._player1.Add(hit.collider.gameObject);
                            }
                            else if (give == 2)
                            {
                                ph._player2.Add(hit.collider.gameObject);
                            }
                            else if (give == 3)
                            {
                                ph._player3.Add(hit.collider.gameObject);
                            }
                            else if (give == 4)
                            {
                                ph._player4.Add(hit.collider.gameObject);
                            }
                        }
                    }
                    if (diverTreasure)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            
                            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);
                            var give = 0;
                            for (int i = 0; i < gm.players.Length; i++)
                            {
                                if (gm.players[i].name == "Diver_Front")
                                {
                                    give = i;
                                }
                            }

                            if (give == 1)
                            {
                                ph._player1.Add(hit.collider.gameObject);
                            }
                            else if (give == 2)
                            {
                                ph._player2.Add(hit.collider.gameObject);
                            }
                            else if (give == 3)
                            {
                                ph._player3.Add(hit.collider.gameObject);
                            }
                            else if (give == 4)
                            {
                                ph._player4.Add(hit.collider.gameObject);
                            }
                        }
                    }
                    if (messengerTreasure)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            
                            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);
                            var give = 0;
                            for (int i = 0; i < gm.players.Length; i++)
                            {
                                if (gm.players[i].name == "Messenger_Front")
                                {
                                    give = i;
                                }
                            }

                            if (give == 1)
                            {
                                ph._player1.Add(hit.collider.gameObject);
                            }
                            else if (give == 2)
                            {
                                ph._player2.Add(hit.collider.gameObject);
                            }
                            else if (give == 3)
                            {
                                ph._player3.Add(hit.collider.gameObject);
                            }
                            else if (give == 4)
                            {
                                ph._player4.Add(hit.collider.gameObject);
                            }
                        }
                    }
                    if (explorerTreasure)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            
                            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);
                            var give = 0;
                            for (int i = 0; i < gm.players.Length; i++)
                            {
                                if (gm.players[i].name == "Explorer_Front")
                                {
                                    give = i;
                                }
                            }

                            if (give == 1)
                            {
                                ph._player1.Add(hit.collider.gameObject);
                            }
                            else if (give == 2)
                            {
                                ph._player2.Add(hit.collider.gameObject);
                            }
                            else if (give == 3)
                            {
                                ph._player3.Add(hit.collider.gameObject);
                            }
                            else if (give == 4)
                            {
                                ph._player4.Add(hit.collider.gameObject);
                            }
                        }
                    }
                    if (navigatorTreasure)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            
                            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector3.forward,Mathf.Infinity);
                            var give = 0;
                            for (int i = 0; i < gm.players.Length; i++)
                            {
                                if (gm.players[i].name == "Navigator_Front")
                                {
                                    give = i;
                                }
                            }

                            if (give == 1)
                            {
                                ph._player1.Add(hit.collider.gameObject);
                            }
                            else if (give == 2)
                            {
                                ph._player2.Add(hit.collider.gameObject);
                            }
                            else if (give == 3)
                            {
                                ph._player3.Add(hit.collider.gameObject);
                            }
                            else if (give == 4)
                            {
                                ph._player4.Add(hit.collider.gameObject);
                            }
                        }
                    }
        }
        if (capture)
        {
            var fires = 0;
            var earths = 0;
            var oceans = 0;
            var winds = 0;
            if (ph._currentPlayer == 1)
            {
                for (int i = 0; i < ph._player1.Count; i++)
                {
                    if (ph._player1[i].name == "the_Crystal_of_Fire")
                    {
                        fires++;
                    }
                    else if (ph._player1[i].name == "The_Earth_Stone")
                    {
                        earths++;
                    }
                    else if (ph._player1[i].name == "the_Ocean_Chalice")
                    {
                        oceans++;
                    }
                    else if (ph._player1[i].name == "the_Statue_of_the_Wind")
                    {
                        winds++;
                    }
                }
            }
            else if (ph._currentPlayer == 2)
            {
                for (int i = 0; i < ph._player2.Count; i++)
                {
                    if (ph._player2[i].name == "the_Crystal_of_Fire")
                    {
                        fires++;
                    }
                    else if (ph._player2[i].name == "The_Earth_Stone")
                    {
                        earths++;
                    }
                    else if (ph._player2[i].name == "the_Ocean_Chalice")
                    {
                        oceans++;
                    }
                    else if (ph._player2[i].name == "the_Statue_of_the_Wind")
                    {
                        winds++;
                    }
                }
            }
            else if (ph._currentPlayer == 3)
            {
                for (int i = 0; i < ph._player3.Count; i++)
                {
                    if (ph._player3[i].name == "the_Crystal_of_Fire")
                    {
                        fires++;
                    }
                    else if (ph._player3[i].name == "The_Earth_Stone")
                    {
                        earths++;
                    }
                    else if (ph._player3[i].name == "the_Ocean_Chalice")
                    {
                        oceans++;
                    }
                    else if (ph._player3[i].name == "the_Statue_of_the_Wind")
                    {
                        winds++;
                    }
                }   
            }
            else if (ph._currentPlayer == 4)
            {
                for (int i = 0; i < ph._player4.Count; i++)
                {
                    if (ph._player4[i].name == "the_Crystal_of_Fire")
                    {
                        fires++;
                    }
                    else if (ph._player4[i].name == "The_Earth_Stone")
                    {
                        earths++;
                    }
                    else if (ph._player4[i].name == "the_Ocean_Chalice")
                    {
                        oceans++;
                    }
                    else if (ph._player4[i].name == "the_Statue_of_the_Wind")
                    {
                        winds++;
                    }
                }
            }
            var currentPlayer = gm.players[ph._currentPlayer - 1];
            int flame1 = 0;
            int flame2 = 0;
            int earth1 = 0;
            int earth2 = 0;
            int ocean1 = 0;
            int ocean2 = 0;
            int wind1 = 0;
            int wind2 = 0;
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Cave_of_Embers")
                {
                    flame1 = i;
                }
            } 
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Cave_of_Shadows")
                {
                    flame2 = i;
                }
            }
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Temple_of_the_Moon")
                {
                    earth1 = i;
                }
            }
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Temple_of_the_Sun")
                {
                    earth2 = i;
                }
            }
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Coral_Palace")
                {
                    ocean1 = i;
                }
            }
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Tidal_Palace")
                {
                    ocean2 = i;
                }
            }
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Whispering_Garden")
                {
                    wind1 = i;
                }
            }
            for (int i = 0; i < tiles._object.Count; i++)
            {
                if (tiles._object[i].name == "Howling_Garden")
                {
                    wind2 = i;
                }
            }
            if ((currentPlayer.transform.parent == gm.boardPositions[flame1] || 
                currentPlayer.transform.parent == gm.boardPositions[flame2]) && fires >= 4)
            {
                fireCollected = true;
                actions++;
                if (ph._currentPlayer == 1)
            {
                for (int i = 0; i < ph._player1.Count; i++)
                {
                    if (ph._player1[i].name == "the_Crystal_of_Fire")
                    {
                        ph._player1.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (ph._currentPlayer == 2)
            {
                for (int i = 0; i < ph._player2.Count; i++)
                {
                    if (ph._player2[i].name == "the_Crystal_of_Fire")
                    {
                        ph._player2.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (ph._currentPlayer == 3)
            {
                for (int i = 0; i < ph._player3.Count; i++)
                {
                    if (ph._player3[i].name == "the_Crystal_of_Fire")
                    {
                        ph._player3.RemoveAt(i);
                        i--;
                    }
                }   
            }
            else if (ph._currentPlayer == 4)
            {
                for (int i = 0; i < ph._player4.Count; i++)
                {
                    if (ph._player4[i].name == "the_Crystal_of_Fire")
                    {
                        ph._player4.RemoveAt(i);
                        i--;
                    }
                }
            }
            }
            else if ((currentPlayer.transform.parent == gm.boardPositions[earth1] || 
                    currentPlayer.transform.parent == gm.boardPositions[earth2]) && earths >= 4)
            {
                earthCollected = true;
                actions++;
                if (ph._currentPlayer == 1)
                {
                    for (int i = 0; i < ph._player1.Count; i++)
                    {
                        if (ph._player1[i].name == "The_Earth_Stone")
                        {
                            ph._player1.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (ph._currentPlayer == 2)
                {
                    for (int i = 0; i < ph._player2.Count; i++)
                    {
                        if (ph._player2[i].name == "The_Earth_Stone")
                        {
                            ph._player2.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (ph._currentPlayer == 3)
                {
                    for (int i = 0; i < ph._player3.Count; i++)
                    {
                        if (ph._player3[i].name == "The_Earth_Stone")
                        {
                            ph._player3.RemoveAt(i);
                            i--;
                        }
                    }   
                }
                else if (ph._currentPlayer == 4)
                {
                    for (int i = 0; i < ph._player4.Count; i++)
                    {
                        if (ph._player4[i].name == "The_Earth_Stone")
                        {
                            ph._player4.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            else if ((currentPlayer.transform.parent == gm.boardPositions[ocean1] || 
                     currentPlayer.transform.parent == gm.boardPositions[ocean2]) && oceans >= 4)
            {
                oceanCollected = true;
                actions++;
                if (ph._currentPlayer == 1)
                {
                    for (int i = 0; i < ph._player1.Count; i++)
                    {
                        if (ph._player1[i].name == "the_Ocean_Chalice")
                        {
                            ph._player1.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (ph._currentPlayer == 2)
                {
                    for (int i = 0; i < ph._player2.Count; i++)
                    {
                        if (ph._player2[i].name == "the_Ocean_Chalice")
                        {
                            ph._player2.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (ph._currentPlayer == 3)
                {
                    for (int i = 0; i < ph._player3.Count; i++)
                    {
                        if (ph._player3[i].name == "the_Ocean_Chalice")
                        {
                            ph._player3.RemoveAt(i);
                            i--;
                        }
                    }   
                }
                else if (ph._currentPlayer == 4)
                {
                    for (int i = 0; i < ph._player4.Count; i++)
                    {
                        if (ph._player4[i].name == "the_Ocean_Chalice")
                        {
                            ph._player4.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            else if ((currentPlayer.transform.parent == gm.boardPositions[wind1] || 
                     currentPlayer.transform.parent == gm.boardPositions[wind1]) && winds >= 4)
            {
                windCollected = true;
                actions++;
                if (ph._currentPlayer == 1)
                {
                    for (int i = 0; i < ph._player1.Count; i++)
                    {
                        if (ph._player1[i].name == "the_Statue_of_the_Wind")
                        {
                            ph._player1.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (ph._currentPlayer == 2)
                {
                    for (int i = 0; i < ph._player2.Count; i++)
                    {
                        if (ph._player2[i].name == "the_Statue_of_the_Wind")
                        {
                            ph._player2.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (ph._currentPlayer == 3)
                {
                    for (int i = 0; i < ph._player3.Count; i++)
                    {
                        if (ph._player3[i].name == "the_Statue_of_the_Wind")
                        {
                            ph._player3.RemoveAt(i);
                            i--;
                        }
                    }   
                }
                else if (ph._currentPlayer == 4)
                {
                    for (int i = 0; i < ph._player4.Count; i++)
                    {
                        if (ph._player4[i].name == "the_Statue_of_the_Wind")
                        {
                            ph._player4.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        if (actions == 3)
        {
            var position = offHand.transform.position;
            var floodCard1 = floodDeck._object[0];
            var floodCard2 = floodDeck._object[1];
            var floodCard3 = floodDeck._object[2];
            var floodCard4 = floodDeck._object[3];
            var floodCard5 = floodDeck._object[4];

            DrawTreasure();
            if (gm.difficulty < 2)
            {
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard1.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard2.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
            }
            else if (gm.difficulty < 5)
            {
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard1.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard2.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard3.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
            }
            else if (gm.difficulty < 7)
            {
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard1.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard2.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard3.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard4.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
            }
            else if (gm.difficulty < 9)
            {
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard1.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard2.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard3.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard4.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
                for (int i = 0; i < tiles._object.Count; i++)
                {
                    if (tiles._object[i].name == floodCard5.name)
                    {
                        Debug.Log("less 2");
                        var tilePos = tiles._object.IndexOf(tiles._object[i]);
                        gm.flooded[tilePos] = true;
                        tiles._object[i].gameObject.GetComponent<SpriteRenderer>().color = Color.blue;

                    }
                }
            }
            else if (gm.difficulty == 9)
            {
                SceneManager.LoadScene("LoseEndScene");
            }
            ph._currentPlayer++;
            actions = 0;
        }
    }

    void DrawTreasure()
    {
        for (int i = 0; i < ph._player1.Count; i++)
        {
            if (ph._player1[i].name == "NullGameObject")
            {
                ph._player1.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < ph._player2.Count; i++)
        {
            if (ph._player2[i].name == "NullGameObject")
            {
                ph._player2.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < ph._player3.Count; i++)
        {
            if (ph._player3[i].name == "NullGameObject" && gs.no_Players > 2)
            {
                ph._player3.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < ph._player4.Count; i++)
        {
            if (ph._player4[i].name == "NullGameObject" && gs.no_Players == 4)
            {
                ph._player4.RemoveAt(i);
                i--;
            }
        }
        var treasuer1 = treasureDeck._object[0];
        var treasuer2 = treasureDeck._object[1];
        treasureDeck._object.Remove(treasuer1);
        treasureDeck._object.Remove(treasuer2);
        if (ph._currentPlayer == 1)
        {
            ph._player1.Add(treasuer1);
            ph._player1.Add(treasuer2);
        }
        else if (ph._currentPlayer == 2)
        {
            ph._player2.Add(treasuer1);
            ph._player2.Add(treasuer2);
        }
        else if (ph._currentPlayer == 3)
        {
            ph._player3.Add(treasuer1);
            ph._player3.Add(treasuer2);
        }
        else if (ph._currentPlayer == 4)
        {
            ph._player4.Add(treasuer1);
            ph._player4.Add(treasuer2);
        }
    }
}