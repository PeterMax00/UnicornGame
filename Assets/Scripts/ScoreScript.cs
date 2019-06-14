using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    public static int highscore;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
     
        score = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore", highscore);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("HIGHSCORE: " + highscore);
      //  Debug.Log("SCORE: " + scoreValue);
        if (scoreValue > highscore)
        {
            highscore = scoreValue;
            PlayerPrefs.SetInt("highscore", highscore);
        }
        score.text = "Score: " + scoreValue;
    }
}
