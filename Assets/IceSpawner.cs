using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpawner : MonoBehaviour
{
    private float starTimeBtwSpawn = 5f;

    private float timeBtwSpawn;
  
    public GameObject ice;


    private void Update()
    {
        //if (starTimeBtwSpawn > 0.2f)
      //  { 
           // starTimeBtwSpawn = 1 - ScoreScript.scoreValue * 0.01f;
       // }


        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, 3);
            if (rand == 0)
            {
                if (BigHoleSpawner.bigRed == false)
                    Instantiate(ice, new Vector3(-1, 1f, 0), Quaternion.identity);
            }
            else if (rand == 1)
            {
                if (BigHoleSpawner.bigBlue == false)
                    Instantiate(ice, new Vector3(0, 1f, 0), Quaternion.identity);

            }
            else if (rand == 2)
            {
                if (BigHoleSpawner.bigYellow == false)
                    Instantiate(ice, new Vector3(1, 1f, 0), Quaternion.identity);
            }

            timeBtwSpawn = starTimeBtwSpawn;


        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }


}
