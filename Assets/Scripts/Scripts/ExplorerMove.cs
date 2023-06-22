using UnityEngine;

namespace Scripts
{
    public class ExplorerMove : MonoBehaviour
    {
        public GameManager gm;
        public PlayeHand ph;
        public GameObject o;
        public GameObject currentPlayer;
        public Actions _actions;

        
        
        public void MoveExplorer()
        {
             if (currentPlayer.transform.parent.name == gm.boardPositions[0].name) 
             {
                 if (o.transform.parent.name == gm.boardPositions[1].name)
                 {
                     ifContents();
                 }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    ifContents();

                                }
                                }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[1].name)
             {
                                if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[2].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[3].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[4].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[1].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[5].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[10].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[1].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[6].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[7].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[2].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[8].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[9].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {                     ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[10].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {                     ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[11].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[17].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[12].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[6].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[13].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[7].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[14].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    ifContents();

                                                                    }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[15].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {
                                                        ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[16].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name) 
                                {
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                {
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[17].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[11].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[18].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    ifContents();

                                }   
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[19].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                { 
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[20].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[21].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[22].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name) 
                                { 
                                    ifContents();

                                }
                            }
             else if (currentPlayer.transform.parent.name == gm.boardPositions[23].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    ifContents();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                {
                                    ifContents();

                                }
                            }
                            Debug.Log("explorer");
        }

        private void ifContents()
        {
            gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
            gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
            _actions._actions = true;
        }
    }
}