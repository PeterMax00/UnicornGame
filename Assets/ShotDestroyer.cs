using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "shotBlue" || other.tag == "shotYellow" || other.tag == "shotRed")
        {
            //Debug.Log("TOUCHED");
            Destroy(other.gameObject);
        }
    }
}
