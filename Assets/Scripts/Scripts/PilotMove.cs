using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Scripts
{
    public class PilotMove : MonoBehaviour
    {
        public Button pilotAction;
        public Button moveButton;
        public Button shoreUpButton;
        public Button treasureButton;
        public Button captureButton;
        public bool pilotAbility = false;
        public GameManager gm;
        public PlayeHand ph;
        public GameObject o;
        public Actions _actions;
        public GameObject currentPlayer;

        public void MovePilot()
        {
             pilotAction.gameObject.SetActive(true);
                            moveButton.gameObject.SetActive(false);
                            shoreUpButton.gameObject.SetActive(false);
                            treasureButton.gameObject.SetActive(false);
                            captureButton.gameObject.SetActive(false);
                            if (pilotAbility)
                            {
                                ifContent();
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[0].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[1].name) 
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[1].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {                                ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {                                ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[2].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {                                ifContent();

                                } 
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {                                ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[3].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {                                ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {                                ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {                                 ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[10].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[11].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[17].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[12].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[6].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[13].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[7].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[14].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[15].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[16].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[17].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[11].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[20].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    ifContent();

                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[21].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    ifContent();

                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
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
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                {
                                    ifContent();

                                }
                            }

                            Debug.Log("pilot");
                           
        }
        public void ifContent()
        {
            gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
            gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
            _actions._actions = true;
            pilotAction.gameObject.SetActive(false);
            moveButton.gameObject.SetActive(true);
            shoreUpButton.gameObject.SetActive(true);
            treasureButton.gameObject.SetActive(true);
            captureButton.gameObject.SetActive(true);
        }
    }
}