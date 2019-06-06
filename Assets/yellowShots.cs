using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yellowShots : MonoBehaviour
{
    public static int yellowShotsCounter;

    Text score;

    // Start is called before the first frame update
    void Start()
    {

        score = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        yellowShotsCounter = 5 - YellowShotSpawner.yellowShotCounter;
        score.text = "" + yellowShotsCounter;
    }
}
