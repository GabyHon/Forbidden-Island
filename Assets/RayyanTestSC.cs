using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayyanTestSC : MonoBehaviour
{
    public GameObject PlayerHandObj;
    private PlayeHand player_hand;
    
    // Start is called before the first frame update
    void Start()
    {
        player_hand = PlayerHandObj.GetComponent<PlayeHand>();
        player_hand._gameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
