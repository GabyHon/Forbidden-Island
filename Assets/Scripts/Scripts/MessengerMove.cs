using UnityEngine;

namespace Scripts
{
    public class MessengerMove : MonoBehaviour
    {
        public GameManager gm;
        public PlayeHand ph;
        public GameObject o;
        public int actions;
        public GameObject currentPlayer;
        public void MoveMessenger()
        
        {
            if (currentPlayer.transform.parent.name == gm.boardPositions[0].name) 
                                {
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[2].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[13].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[7].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[16].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[10].name) 
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[18].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[13].name) 
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[19].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name) 
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[21].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[16].name) 
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
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[22].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[19].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                }
                            }
                            Debug.Log("messenger");
        }
    }
}