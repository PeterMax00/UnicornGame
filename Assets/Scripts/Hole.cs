using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public static float speed = 1;
    public float acceleration;
    public GameObject player;
    static public float parX;
    public AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    private void Update()
    {
       // Debug.Log("SPEED " + speed);
       if(speed < 5f)
       {
            speed =1+ ScoreScript.scoreValue * 0.001f;
       }
        
       
       
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        
        
            
    
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            Reset();
        }
        
    }

    private void Reset()
    {
        ScoreScript.scoreValue = 0;
        //SceneManager.LoadScene("GameNewCtrl", LoadSceneMode.Single);
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
        
    }

    private void OnMouseDown()
    {

  
        if (MyMouse.playerPos.x-1.2f == transform.position.x)
        {
            sound.Play();
            ScoreScript.scoreValue += 1;
            Destroy(this.gameObject);
           
        }
    }

    IEnumerator Blink()
    {
        float y;
        y = this.transform.position.y;
        transform.position = new Vector3(this.transform.position.x, y- 1, this.transform.position.z);
        yield return new WaitForSeconds(1.5f);
        transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
    }
}
