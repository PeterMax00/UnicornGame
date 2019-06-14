using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float starTimeBtwSpawn = 1f;

    private float timeBtwSpawn;
   // public GameObject[] Bigfloor;
    public GameObject[] floors;
    public GameObject frame;
    

    private void Update()
    {
       // Debug.Log("SPAWN: " + starTimeBtwSpawn);
        if(starTimeBtwSpawn > 0.1f)
        {
         starTimeBtwSpawn =1 - ScoreScript.scoreValue * 0.01f;
       }
     
       

        if (timeBtwSpawn <= 0)
        {

            if (DetectHoles.stopRandBlue)
            {
               // Debug.Log("BLUE STOPPED");
                int randB = Random.Range(0, floors.Length - 1);
                if (randB == 0)
                {
                    // Debug.Log("RED " + BigHoleSpawner.bigRed);
                    if (BigHoleSpawner.bigRed == false)
                        Instantiate(floors[randB], new Vector3(-1, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(-1, 0.52f, 0), Quaternion.identity);
                }
                else if (randB == 1)
                {
                    //Debug.Log("YELLOW " + BigHoleSpawner.bigYellow);
                    if (BigHoleSpawner.bigYellow == false)
                        Instantiate(floors[randB], new Vector3(1, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(1, 0.52f, 0), Quaternion.identity);
                }

                timeBtwSpawn = starTimeBtwSpawn;

            }
            else if (DetectHoles.stopRandRed)
            {
              //  Debug.Log("RED STOPPED");
                int randR = Random.Range(0, floors.Length - 1);

                if (randR == 0)
                {
                    //Debug.Log("BLUE " + BigHoleSpawner.bigBlue);
                    if (BigHoleSpawner.bigBlue == false)
                        Instantiate(floors[randR], new Vector3(0, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(0, 0.52f, 0), Quaternion.identity);

                }
                else if (randR == 1)
                {
                    //Debug.Log("YELLOW " + BigHoleSpawner.bigYellow);
                    if (BigHoleSpawner.bigYellow == false)
                        Instantiate(floors[randR], new Vector3(1, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(1, 0.52f, 0), Quaternion.identity);
                }

                timeBtwSpawn = starTimeBtwSpawn;

            }
            else if (DetectHoles.stopRandYellow)
            {
               // Debug.Log("YELLOW STOPPED");
                int randY = Random.Range(0, floors.Length - 1);
                if (randY == 0)
                {
                    // Debug.Log("RED " + BigHoleSpawner.bigRed);
                    if (BigHoleSpawner.bigRed == false)
                        Instantiate(floors[randY], new Vector3(-1, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(-1, 0.52f, 0), Quaternion.identity);
                }
                else if (randY == 1)
                {
                    //Debug.Log("BLUE " + BigHoleSpawner.bigBlue);
                    if (BigHoleSpawner.bigBlue == false)
                        Instantiate(floors[randY], new Vector3(0, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(0, 0.52f, 0), Quaternion.identity);

                }


                timeBtwSpawn = starTimeBtwSpawn;
            }
            else
            {
               // Debug.Log("NO STOPPED");

                int rand = Random.Range(0, floors.Length);
                if (rand == 0)
                {
                    // Debug.Log("RED " + BigHoleSpawner.bigRed);
                    if (BigHoleSpawner.bigRed == false)
                        Instantiate(floors[rand], new Vector3(-1, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(-1, 0.52f, 0), Quaternion.identity);
                }
                else if (rand == 1)
                {
                    //Debug.Log("BLUE " + BigHoleSpawner.bigBlue);
                    if (BigHoleSpawner.bigBlue == false)
                        Instantiate(floors[rand], new Vector3(0, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(0, 0.52f, 0), Quaternion.identity);

                }
                else if (rand == 2)
                {
                    //Debug.Log("YELLOW " + BigHoleSpawner.bigYellow);
                    if (BigHoleSpawner.bigYellow == false)
                        Instantiate(floors[rand], new Vector3(1, 0.52f, 0), Quaternion.identity);
                    // Instantiate(frame, new Vector3(1, 0.52f, 0), Quaternion.identity);
                }
            
                timeBtwSpawn = starTimeBtwSpawn;
            }

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

   
}
