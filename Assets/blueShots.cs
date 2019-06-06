using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blueShots : MonoBehaviour
{
    public static int blueShotsCounter;

    Text score;

    // Start is called before the first frame update
    void Start()
    {

        score = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        blueShotsCounter = 5 - BlueShotSpawner.blueShotCounter;
        score.text = "" + blueShotsCounter;
    }
}
