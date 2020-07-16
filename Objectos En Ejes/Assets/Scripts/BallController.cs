using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float STARTINGFORCE = 500F;
    bool hasStarted = false;

    Rigidbody rbody;
    Vector3 startingForce = new Vector3(1, 1); 


    private void Awake()
    {
        rbody = GetComponent<Rigidbody>();   

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted && Input.GetButtonDown("Fire1")) 
        {
            hasStarted = true;
            startingForce *= STARTINGFORCE;

            rbody.AddForce(startingForce);
        }
        
    }
}
