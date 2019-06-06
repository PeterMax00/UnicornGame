﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueShotSpawner : MonoBehaviour
{
    public static bool bluePressed;
    public static int blueShotCounter;
    public float maxTimeDelay;
    private float timeDelay;
    public int maxShotsNumber;

    // Start is called before the first frame update
    void Start()
    {

        timeDelay = maxTimeDelay;
        blueShotCounter = 0;
        bluePressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("RED SHOTS:" + blueShotCounter);

        if (blueShotCounter > 0)
        {
            if (timeDelay >= 0)
            {
                Debug.Log(timeDelay);
                timeDelay -= Time.deltaTime;

            }
            else
            {
                timeDelay = maxTimeDelay;
                blueShotCounter -= 1;
                Debug.Log("LOAD SHOT");
            }
        }





    }

    
    private void OnMouseDown()
    {

        if ((MyMouse.onBlue) && ( !MyMouse.beingDragged))
        {
            
            if (blueShotCounter < maxShotsNumber)
            {
                bluePressed = true;
                blueShotCounter += 1;
            }

        }
    }
}
