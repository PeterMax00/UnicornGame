using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IceCream : MonoBehaviour
{
    public AudioSource sound;
   
    private float speed = 1;

    private void Start()
    {
        sound = GetComponent<AudioSource>();

    }

    private void Update()
    {

        if (speed < 5f)
        {
            speed += ScoreScript.scoreValue * 0.001f;
        }


        transform.Translate(-Vector3.forward * speed * Time.deltaTime);






    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreScript.scoreValue += 10;
           // audioSrc.PlayOneShot(iceSound);
           // sound.Play();
            Destroy(this.gameObject);
        }

    }

 
}
