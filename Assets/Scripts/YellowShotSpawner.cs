using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowShotSpawner : MonoBehaviour
{

    public static bool yellowPressed;
    public static int yellowShotCounter;
    public float maxTimeDelay;
    private float timeDelay;
    public int maxShotsNumber;

    // Start is called before the first frame update
    void Start()
    {

        timeDelay = maxTimeDelay;
        yellowShotCounter = 0;
        yellowPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("RED SHOTS:" + yellowShotCounter);

        if (yellowShotCounter > 0)
        {
            if (timeDelay >= 0)
            {
                Debug.Log(timeDelay);
                timeDelay -= Time.deltaTime;

            }
            else
            {
                timeDelay = maxTimeDelay;
                yellowShotCounter -= 1;
                Debug.Log("LOAD SHOT");
            }
        }





    }
    private void OnMouseDown()
    {

        if ((MyMouse.onYellow) && (!MyMouse.beingDragged))
        {
            if (yellowShotCounter < maxShotsNumber)
            {
                yellowPressed = true;
                yellowShotCounter += 1;
            }

        }
    }
}
