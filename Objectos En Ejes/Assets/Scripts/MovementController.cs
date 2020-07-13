using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    float speedY = 20f;
    Vector3 deltaPos = new Vector3(); 

    const float MIN_LIM_Y = -4.44f, MAX_LIM_Y = 4.44f; 

    // Update is called once per frame
    void Update()
    {
        deltaPos.y = Input.GetAxis("Vertical") * speedY * Time.deltaTime;
        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(            
            gameObject.transform.position.x, 
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y), 
            gameObject.transform.position.z
            );
    }
}
