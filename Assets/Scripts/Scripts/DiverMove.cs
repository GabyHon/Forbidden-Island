using System;
using UnityEngine;

namespace Scripts
{
    public class DiverMove : MonoBehaviour
    {
        public GameManager gm;
        public PlayeHand ph;
        public GameObject o;
        public GameObject currentPlayer;
        public Actions _actions;


        

        public void MoveDiver()
        {
                            if (currentPlayer.transform.parent.name == gm.boardPositions[0].name)
                            {
                                Debug.Log("pos1");
                                if (o.transform.parent.name == gm.boardPositions[1].name)
                                {
                                    ifContent();
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name 
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false) && (gm.flooded[14] 
                                             || gm.boardPositions[14].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false) && (gm.flooded[8] 
                                             || gm.boardPositions[8].active == false) && (gm.flooded[14] 
                                             || gm.boardPositions[14].active == false)&& (gm.flooded[19] 
                                             || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[1].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name)
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false) && (gm.flooded[9] 
                                             || gm.boardPositions[9].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false) && (gm.flooded[9]
                                             || gm.boardPositions[9].active == false) && (gm.flooded[15] 
                                             || gm.boardPositions[15].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false) && (gm.flooded[9] 
                                             || gm.boardPositions[9].active == false) && (gm.flooded[15] 
                                             || gm.boardPositions[15].active == false)&& (gm.flooded[20] 
                                             || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                                                    }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[2].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name && gm.flooded[3])
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false)
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                                                       ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[3].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name)
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[4].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[1].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[5].name)
                            {
                                 if (o.transform.parent.name == gm.boardPositions[10].name)
                                 {
                                     ifContent();

                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[16].name
                                          && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                 {
                                     ifContent();

                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[21].name
                                          && (gm.flooded[10] || gm.boardPositions[10].active == false)
                                          && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                 {
                                     ifContent();

                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[4].name)
                                 {
                                     ifContent();

                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[3].name
                                          && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                 {                                    ifContent();

                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[2].name
                                          && (gm.flooded[4] || gm.boardPositions[4].active == false)
                                          && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                 {
                                     ifContent();

                                 }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[6].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name)
                                {
                                    ifContent();

                                                                    }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[7].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[2].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name)
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    ifContent();

                                                                    } 
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    ifContent();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[13].name)
                                {
                                    ifContent();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    ifContent();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[6].name)
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[8].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name)
                                {
                                                                       ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[9].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[4].name)
                                {
                                    ifContent();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name)
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[11].name
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[10].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[5].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[11].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[17].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[12].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[6].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[16].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[13].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[7].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name
                                         && (gm.flooded[7] || gm.boardPositions[7].active == false))
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[18].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name)
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[14].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[8].name)
                                {                                    ifContent();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[3].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[19].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[15].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[9].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name)
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[23].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[16].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[10].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[17].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[11].name)
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[16].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name
                                    && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[18].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[13].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name
                                         && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {                                    ifContent();

                                }else if (o.transform.parent.name == gm.boardPositions[2].name
                                          && (gm.flooded[7] || gm.boardPositions[7].active == false)
                                          && (gm.flooded[13] || gm.boardPositions[13].active == false))
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[19].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name)
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[18].name)
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[20].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[15].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name)
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[21].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[16].name)
                                {                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[10].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name
                                         && (gm.flooded[16] || gm.boardPositions[16].active == false)
                                         && (gm.flooded[10] || gm.boardPositions[10].active == false))
                                {                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name)
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[22].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[19].name)
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[14].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false))
                                {
                                    ifContent();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[3].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name
                                         && (gm.flooded[19] || gm.boardPositions[19].active == false)
                                         && (gm.flooded[14] || gm.boardPositions[14].active == false)
                                         && (gm.flooded[8] || gm.boardPositions[8].active == false)
                                         && (gm.flooded[3] || gm.boardPositions[3].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name)
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[23].name)
                            {
                                 if (o.transform.parent.name == gm.boardPositions[20].name) 
                                 {
                                     ifContent();

                                 }
                                 else if (o.transform.parent.name == gm.boardPositions[15].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name
                                         && (gm.flooded[20] || gm.boardPositions[20].active == false)
                                         && (gm.flooded[15] || gm.boardPositions[15].active == false)
                                         && (gm.flooded[9] || gm.boardPositions[9].active == false)
                                         && (gm.flooded[4] || gm.boardPositions[4].active == false))
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name)
                                {
                                    ifContent();

                                }
                            }
                            Debug.Log("Diver");
        }

        public void ifContent()
        {
            gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
            gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
            _actions._actions = true;
        }
    }
}