﻿using System;
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
        public int actions;
        public Actions _actions;
        public GameObject currentPlayer;
        private void Start()
        {
            actions = _actions.actions;
        }

        public void MovePilot()
        {
             pilotAction.gameObject.SetActive(true);
                            moveButton.gameObject.SetActive(false);
                            shoreUpButton.gameObject.SetActive(false);
                            treasureButton.gameObject.SetActive(false);
                            captureButton.gameObject.SetActive(false);
                            if (pilotAbility)
                            {
                                gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                actions++;
                                pilotAction.gameObject.SetActive(false);
                                moveButton.gameObject.SetActive(true);
                                shoreUpButton.gameObject.SetActive(true);
                                treasureButton.gameObject.SetActive(true);
                                captureButton.gameObject.SetActive(true);
                                pilotAbility = false;
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[0].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[1].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[1].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[2].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                } 
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[3].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[0].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++;
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[2].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[4].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[1].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position; 
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[5].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[10].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[6].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[7].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true); 
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[7].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[2].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[6].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[8].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[3].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[7].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[9].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[4].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[10].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[5].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[11].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[11].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[17].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[12].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[6].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                                                    moveButton.gameObject.SetActive(true);
                                                                    shoreUpButton.gameObject.SetActive(true);
                                                                    treasureButton.gameObject.SetActive(true);
                                                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[13].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[7].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                                                    moveButton.gameObject.SetActive(true);
                                                                    shoreUpButton.gameObject.SetActive(true);
                                                                    treasureButton.gameObject.SetActive(true);
                                                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[12].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[14].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[8].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[15].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[9].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                                                    moveButton.gameObject.SetActive(true);
                                                                    shoreUpButton.gameObject.SetActive(true);
                                                                    treasureButton.gameObject.SetActive(true);
                                                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[16].name)
                            { 
                                if (o.transform.parent.name == gm.boardPositions[10].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[17].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                                                    moveButton.gameObject.SetActive(true);
                                                                    shoreUpButton.gameObject.SetActive(true);
                                                                    treasureButton.gameObject.SetActive(true);
                                                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[17].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[11].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[18].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[13].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                                                    moveButton.gameObject.SetActive(true);
                                                                    shoreUpButton.gameObject.SetActive(true);
                                                                    treasureButton.gameObject.SetActive(true);
                                                                    captureButton.gameObject.SetActive(true);
                                }   
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[19].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[14].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[18].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[20].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[15].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[21].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[21].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[16].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[22].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[19].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[23].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                            }
                            else if (currentPlayer.transform.parent.name == gm.boardPositions[23].name)
                            {
                                if (o.transform.parent.name == gm.boardPositions[20].name) 
                                { 
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                }
                                else if (o.transform.parent.name == gm.boardPositions[22].name) 
                                {
                                    gm.players[ph._currentPlayer - 1].transform.position = o.transform.position;
                                    gm.players[ph._currentPlayer - 1].transform.parent = o.transform.parent.transform;
                                    actions++; 
                                    pilotAction.gameObject.SetActive(false);
                                    moveButton.gameObject.SetActive(true);
                                    shoreUpButton.gameObject.SetActive(true);
                                    treasureButton.gameObject.SetActive(true);
                                    captureButton.gameObject.SetActive(true);
                                                                }
                            }

                            Debug.Log("pilot");
                           
        }
    }
}