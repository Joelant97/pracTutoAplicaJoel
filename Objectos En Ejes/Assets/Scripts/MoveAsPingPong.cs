using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsPingPong : MonoBehaviour
{

    const float MAX_Y = 8f;
    Vector3 currentPosition = new Vector3();

    const float SPEED_Y = 12f; 

    // Update is called once per frame
    void Update()
    {
        currentPosition.y = -4 + Mathf.PingPong(Time.time * SPEED_Y, MAX_Y);
        gameObject.transform.position = currentPosition; 

    }


}
