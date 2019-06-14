using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Hole : MonoBehaviour
{

    private double holeAndPlayerDist;
    public static float speed = 2;
    public float acceleration;
    public GameObject player;
    public static bool freezGameOver;
    static public float parX;
    public static Vector3 holePosition;

    private void Start()
    {
        freezGameOver = false;
    }
    private void Update()
    {
        
       // Debug.Log("SPEED " + speed);
       if(speed < 5f)
       {
            speed =2+ ScoreScript.scoreValue * 0.001f;
       }
        
       
       
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        
        if(MyMouse.onRed && this.transform.position.x == -1)
        {
            //BLINK RED HOLES
           // this.gameObject.transform.position =
            
        }
        if (MyMouse.onBlue && this.transform.position.x == 0)
        {
            //BLINK BLUE HOLES
        }
        if (MyMouse.onYellow && this.transform.position.x == 1)
        {
            //BLINK YELLOW HOLES
        }

        

    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            //ScoreScript.gameOver = "GAMEOVER";

            /* GameObject[] bigBlues = GameObject.FindGameObjectsWithTag("bigBlue");
             GameObject[] bigReds = GameObject.FindGameObjectsWithTag("bigRed");
             GameObject[] bigYellows = GameObject.FindGameObjectsWithTag("bigYellow");

             GameObject[] holeBlues = GameObject.FindGameObjectsWithTag("holeBlue");
             GameObject[] holeReds = GameObject.FindGameObjectsWithTag("holeRed");
             GameObject[] holeYellows = GameObject.FindGameObjectsWithTag("holeYellow");

             */
            freezGameOver = true;
            Handheld.Vibrate();
            SoundManagerScript.PlaySound("iceSound");
            Debug.Log("STOP, change color hole");

            holePosition = this.transform.position;


            //Reset();
        }
    
        if(other.tag == "shotBlue" || other.tag == "shotYellow" || other.tag == "shotRed")
        {
            ScoreScript.scoreValue += 1;
          //  SoundManagerScript.PlaySound("iceSound");
            // Debug.Log("SCORE " + ScoreScript.scoreValue);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
           
        }
        
    }

    private void Reset()
    {
        ScoreScript.scoreValue = 0;
        //SceneManager.LoadScene("GameNewCtrl", LoadSceneMode.Single);
        SceneManager.LoadScene("MenuH",LoadSceneMode.Single);
        
    }

    /*private void OnMouseDown()
    {

  
        if (MyMouse.playerPos.x-1.2f == transform.position.x)
        {
            sound.Play();
            ScoreScript.scoreValue += 1;
            Destroy(this.gameObject);
           
        }
    }*/

    IEnumerator Blink()
    {
        float y;
        y = this.transform.position.y;
        transform.position = new Vector3(this.transform.position.x, y- 1, this.transform.position.z);
        yield return new WaitForSeconds(1.5f);
        transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
    }
}
