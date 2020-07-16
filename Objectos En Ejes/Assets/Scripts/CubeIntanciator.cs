using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Resources;


public class CubeIntanciator : MonoBehaviour
{
    public GameObject RedCube, GreenCube, YellowCube, BlueCube;
    Vector3 startingPosition = new Vector3(0, 7.5f);
    float nextTime;

    const float MIN_TIME = 0.2f, MAX_TIME = 1.5f, MIN_X = -9, MAX_X = 9; 

    // Start is called before the first frame update
    void Start()
    {
        nextTime = GetNextTime(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime) 
        {
            startingPosition.x = Random.Range(MIN_X, MAX_X); 
            Instantiate(NextCube(), startingPosition, Quaternion.identity);
            nextTime = GetNextTime();
        }
    }


    float GetNextTime() 
    {
        return Time.time + Random.Range(MIN_TIME, MAX_TIME); 
    }


    GameObject NextCube()
    {
        switch (Random.Range(0, 4))
        {
            case 0:
                return RedCube;
            case 1:
                return BlueCube;
            case 2:
                return YellowCube; 
            default:
                return GreenCube;
        }
    }

}
