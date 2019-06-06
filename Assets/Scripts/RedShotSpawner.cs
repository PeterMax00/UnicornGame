using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShotSpawner : MonoBehaviour
{
    public static bool redPressed;
    public static int redShotCounter;
    public float maxTimeDelay;
    private float timeDelay;
    public int maxShotsNumber;

    // Start is called before the first frame update
    void Start()
    {

        timeDelay = maxTimeDelay;
        redShotCounter = 0; 
        redPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("RED SHOTS:" + redShotCounter);
        
        if(redShotCounter > 0)
        {
            if (timeDelay >= 0)
            {
                Debug.Log(timeDelay);
                timeDelay -= Time.deltaTime;

            }
            else
            {
                timeDelay = maxTimeDelay;
                redShotCounter -= 1;
                Debug.Log("LOAD SHOT");
            }
        }
       
      



    }
    private void OnMouseDown()
    {

        if ((MyMouse.onRed) && (!MyMouse.beingDragged))
        {
            if(redShotCounter < maxShotsNumber)
            {
                redPressed = true;
                redShotCounter += 1;
            }
            
        }
    }
}
