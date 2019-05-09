using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
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
        if(other.tag == "holeRed" || other.tag == "holeBlue" || other.tag == "holeYellow")
        {
           // Debug.Log("TOUCHED");
            Destroy(other.gameObject);
        }
       
    }
}
