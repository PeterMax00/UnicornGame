using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnMenu()
    {
        Hole.freezGameOver = false;
        DetectHoles.stopRandBlue = false;
        DetectHoles.stopRandRed = false;
        DetectHoles.stopRandYellow = false;
        Time.timeScale = 1.0f;
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("MenuH", LoadSceneMode.Single);
      
     

    }

}
