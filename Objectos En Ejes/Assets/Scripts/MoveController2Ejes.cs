using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController2Ejes : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 movementSpeed = new Vector3(20, 20);
    Vector3 deltaPos = new Vector3();

    const float MIN_LIM_Y = -4.44f, MAX_LIM_Y = 4.44f, MIN_LIM_X = -13.15f, MAX_LIM_X = 13.15f;

    // Update is called once per frame
    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * movementSpeed.x;
        deltaPos.y = Input.GetAxis("Vertical") * movementSpeed.y;
        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_LIM_Y, MAX_LIM_Y),
            gameObject.transform.position.z);

    }
}
