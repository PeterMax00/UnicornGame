﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BigHoleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] BigFloor;
    public static bool spawn;
    public static bool bigBlue, bigYellow, bigRed;
    void Start()
    {
        spawn = false;
        bigBlue = bigYellow = bigRed = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (spawn)
        {
            float x = DetectHoles.parX;
             x = x + 1;
            int i = (int)x;
            if (i == 0)
            {
                if (bigRed != true)
                {
                    bigRed = true;
                    Instantiate(BigFloor[i], new Vector3(i - 1, 0.01f, 50), Quaternion.identity);
                }
            }
               
            if (i == 1)
            {
                if (bigBlue != true)
                {
                    bigBlue = true;
                    Instantiate(BigFloor[i], new Vector3(i - 1, 0.01f, 50), Quaternion.identity);
                }
            }
                
            if (i == 2) 
            {
                if (bigYellow != true)
                {
                    bigYellow = true;
                    Instantiate(BigFloor[i], new Vector3(i - 1, 0.01f, 50), Quaternion.identity);
                }
            }
               

            
            
            spawn = false;
        }
        
    }

  
}
