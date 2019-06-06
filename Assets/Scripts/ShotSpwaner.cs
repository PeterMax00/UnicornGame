using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpwaner : MonoBehaviour
{
    public GameObject[] shots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (YellowShotSpawner.yellowPressed)
        {
            Instantiate(shots[2], new Vector3(1,1,-8), Quaternion.identity);
            YellowShotSpawner.yellowPressed = false;
        }

        if (RedShotSpawner.redPressed)
        {
            Instantiate(shots[0], new Vector3(-1, 1, -8), Quaternion.identity);
            RedShotSpawner.redPressed = false;
        }

        if (BlueShotSpawner.bluePressed)
        {
            Instantiate(shots[1], new Vector3(0, 1, -8), Quaternion.identity);
            BlueShotSpawner.bluePressed = false;
        }


    }
}
