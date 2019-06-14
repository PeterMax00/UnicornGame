using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

  

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

      

    }

    void Update()
    {
       
        
        text.text = "HIGHSCORE:" + ScoreScript.highscore+"\n YOU: "+ScoreScript.scoreValue;

        
    }


}