using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHole : MonoBehaviour
{
    private float speed = Hole.speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "shotBlue" || other.tag == "shotYellow" || other.tag == "shotRed")
        {
            ScoreScript.scoreValue += 1;

          //  Debug.Log("SCORE " + ScoreScript.scoreValue);




            if (this.transform.position.x == -1)
            {
                BigHoleSpawner.bigRed = false;
                Destroy(other.gameObject);
                Destroy(this.gameObject);
               

            }
            else if (this.transform.position.x == 0)
            {
                BigHoleSpawner.bigBlue = false;
                Destroy(other.gameObject);
                Destroy(this.gameObject);
               

            }
            else if (this.transform.position.x == 1)
            {
                BigHoleSpawner.bigYellow = false;
                Destroy(other.gameObject);
                Destroy(this.gameObject);
               
            }
         
            
        }
    }
    void Update()
    {
        
        if (transform.position.z <=-25)
        {
            speed = 0;
            transform.Translate(new Vector3(0, 0, 0));
        }
        else
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
    }

   /* private void OnMouseDown()
    {

        // Debug.Log("PLAYER X: " + player.transform.position.x);
        // Debug.Log("HOLE X: " + transform.position.x);
        if (MyMouse.playerPos.x - 1.2f == transform.position.x)
        {
            //Debug.Log("TOUCHED " + gameObject.tag);
            ScoreScript.scoreValue += 1;
            
            

            

            if(this.transform.position.x == -1)
            {
                BigHoleSpawner.bigRed = false;
                Destroy(this.gameObject);

            }
            else if(this.transform.position.x == 0)
            {
                BigHoleSpawner.bigBlue = false;
                Destroy(this.gameObject);

            }
            else if(this.transform.position.x == 1)
            {
                BigHoleSpawner.bigYellow= false;
                Destroy(this.gameObject);
            }
        }
    } */
}
