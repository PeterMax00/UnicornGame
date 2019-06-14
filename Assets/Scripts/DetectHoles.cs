using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DetectHoles : MonoBehaviour
{
    static public float parX;
    public static int counter;
    public static bool lost;
    public static bool freezeLost;
    public static bool stopRandBlue;
    public static bool stopRandRed;
    public static bool stopRandYellow;
    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        stopRandBlue = false;
        stopRandYellow = false;
        stopRandRed = false;
        freezeLost = false;
        lost = false;
        counter = 0;
    }
    void Update()
    {
        if (counter >= 2)
        {

            //SceneManager.LoadScene("GameNewCtrl", LoadSceneMode.Single);
            freezeLost = true;
            //SceneManager.LoadScene("MenuH", LoadSceneMode.Single);
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "holeBlue" || other.tag == "holeRed" || other.tag == "holeYellow")
        {
            parX = other.transform.position.x;
           // Debug.Log("HIT WALL " + parX);
            BigHoleSpawner.spawn = true;
        }
        if (other.tag == "bigBlue" || other.tag == "bigYellow" || other.tag == "bigRed")
        {
            lost = true;
            counter = counter + 1;

            if(other.tag == "bigBlue")
            {
                stopRandBlue = true;
            }
            if (other.tag == "bigRed")
            {
                stopRandRed = true;
            }
            if (other.tag == "bigYellow")
            {
                stopRandYellow = true;
            }
            // Debug.Log("COUNT = " + counter);
        }

    }
}
