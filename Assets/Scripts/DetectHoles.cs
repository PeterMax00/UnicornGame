using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DetectHoles : MonoBehaviour
{
    static public float parX;
    public static int counter;
    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        counter = 0;
    }
    void Update()
    {
        if (counter >= 2)
        {

            //SceneManager.LoadScene("GameNewCtrl", LoadSceneMode.Single);
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
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
            counter = counter + 1;
            Debug.Log("COUNT = " + counter);
        }

    }
}
