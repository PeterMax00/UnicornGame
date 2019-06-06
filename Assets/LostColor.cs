using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LostColor : MonoBehaviour
{
    private float counter = 1f;
    public static int scoreValue = 0;
    public static string gameOver;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = "";
        score = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        if (DetectHoles.lost)
        {
            score.text = "LOST " + DetectHoles.counter + " COLOR!";
            counter -= Time.deltaTime;
            if(counter <= 0)
            {
                DetectHoles.lost = false;
                score.text = "";
            }
        }
    }
}
