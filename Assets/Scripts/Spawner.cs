using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float starTimeBtwSpawn = 3f;

    private float timeBtwSpawn;
   // public GameObject[] Bigfloor;
    public GameObject[] floors;
    

    private void Update()
    {
       // Debug.Log("SPAWN: " + starTimeBtwSpawn);
        if(starTimeBtwSpawn > 0.1f)
        {
         starTimeBtwSpawn =3 - ScoreScript.scoreValue * 0.01f;
       }
     
       

        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, floors.Length);
            if (rand == 0)
            {
                Debug.Log("RED " + BigHoleSpawner.bigRed);
                if(BigHoleSpawner.bigRed == false)
                     Instantiate(floors[rand],new Vector3(-1,0.01f,0), Quaternion.identity);
            } else if (rand == 1)
            {
                Debug.Log("BLUE " + BigHoleSpawner.bigBlue);
                if (BigHoleSpawner.bigBlue == false)
                    Instantiate(floors[rand], new Vector3(0, 0.01f, 0), Quaternion.identity);

            }
            else if(rand == 2)
            {
                Debug.Log("YELLOW " + BigHoleSpawner.bigYellow);
                if (BigHoleSpawner.bigYellow == false)
                    Instantiate(floors[rand], new Vector3(1, 0.01f, 0), Quaternion.identity);
            }
            
            timeBtwSpawn = starTimeBtwSpawn;


        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

   
}
