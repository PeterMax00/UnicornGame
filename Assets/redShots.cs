using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redShots : MonoBehaviour
{
    public static int redShotsCounter;

    Text score;

    // Start is called before the first frame update
    void Start()
    {

        score = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        redShotsCounter = 5 - RedShotSpawner.redShotCounter;
        score.text = ""+redShotsCounter;
    }
}
