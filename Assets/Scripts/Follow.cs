using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player.transform.position.x == 1)
        {
            Vector3 desPos = new Vector3(2.2f, 1.48f, -8.57f);
            transform.position = Vector3.MoveTowards(transform.position, desPos, 1000f * Time.deltaTime);
        }

        if (player.transform.position.x == 0)
        {
            Vector3 desPos = new Vector3(1.2f, 1.48f, -8.57f);
            transform.position = Vector3.MoveTowards(transform.position, desPos, 1000f * Time.deltaTime);
        }

        if (player.transform.position.x == -1)
        {

            Vector3 desPos = new Vector3(0.2f, 1.48f, -8.57f);
            transform.position = Vector3.MoveTowards(transform.position, desPos, 1000f * Time.deltaTime);

        }
    }
}
