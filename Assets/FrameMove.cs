using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FrameMove : MonoBehaviour
{
    private double holeAndPlayerDist;
    public static float speed = 1;
    public float acceleration;
    public GameObject player;
    static public float parX;
    public AudioSource sound;
    public float counter;
    public static bool blinkRed, blinkBlue, blinkYellow;

    private void Start()
    {
        this.gameObject.SetActive(false);
        blinkRed = false;
        blinkBlue = false;
        blinkYellow = false;
        counter = 0.5f;
        //sound = GetComponent<AudioSource>();
    }
    private void Update()
    {

        // Debug.Log("SPEED " + speed);
        if (speed < 5f)
        {
            speed = 1 + ScoreScript.scoreValue * 0.001f;
        }




        transform.Translate(-Vector3.forward * speed * Time.deltaTime);


        if (MyMouse.onRed && this.transform.position.x == -1)
        {
            blinkRed = true;
            blinkBlue = false;
            blinkYellow = false;
            //BLINK RED HOLES
            this.gameObject.SetActive(true);
            
            //counter -= Time.deltaTime;




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
            Destroy(this.gameObject);
        }

        if (other.tag == "shotBlue" || other.tag == "shotYellow" || other.tag == "shotRed")
        {
            //ScoreScript.scoreValue += 1;

            // Debug.Log("SCORE " + ScoreScript.scoreValue);
            Destroy(other.gameObject);
            //Destroy(this.gameObject);

        }

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
        transform.position = new Vector3(this.transform.position.x, y - 1, this.transform.position.z);
        yield return new WaitForSeconds(1.5f);
        transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
    }
}
