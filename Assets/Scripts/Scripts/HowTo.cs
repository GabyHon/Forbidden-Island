using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowTo : MonoBehaviour
{
    public GameObject howTo;
    public Camera cam;
    public void Exit()
    {
        var transformPosition = new Vector3(0, (float)-2.97, -10);
        cam.transform.position = transformPosition;
    }

    public void HowTwo()
    {
        cam.transform.position = new Vector3(howTo.transform.position.x, howTo.transform.position.y, -10);
    }
}
