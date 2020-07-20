using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speedY = 2;
    Vector3 deltaPos = new Vector3();
    const float MIN_LIM = -4, MAX_LIN = 4; 

    

    // Update is called once per frame
    void Update()
    {
        deltaPos.y = Input.touchSupported && Input.touchCount > 0 ? Input.GetTouch(0).position.y : 0;
        deltaPos.y *= speedY;
        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);

        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x, 
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM, MAX_LIN),
            gameObject.transform.position.z
            );     
 
    }
}
