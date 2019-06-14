using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    private float startY;
    public GameObject player;
    private Vector3 startCameraPosition;
    public GameObject[] shotNumbers;
    public GameObject[] gameOverUI;
    public GameObject lost2Colors;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        this.transform.position = new Vector3(0, 4.6f, 3.75f);
        this.transform.eulerAngles = new Vector3(27.042f, -180, 0);
        startCameraPosition = Camera.main.transform.position;
       //  startY = transform.position.y;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Hole.freezGameOver)
        {
           

            for (int i = 0; i < shotNumbers.Length; i++)
                shotNumbers[i].SetActive(false);

            float step = 100.0f*Time.deltaTime; // calculate distance to move
           Vector3 freezeCameraPosition = new Vector3(player.transform.position.x, player.transform.position.y+1.5f, player.transform.position.z+5f);
            Camera.main.transform.position = Vector3.MoveTowards(transform.position, freezeCameraPosition, step);
            if(Camera.main.transform.position == freezeCameraPosition)
             {
            Camera.main.transform.position = freezeCameraPosition;
                Time.timeScale = 0;
                for (int i = 0; i < gameOverUI.Length; i++)
                    gameOverUI[i].SetActive(true);
                // STEPPED INTO HOLE
                    
            }
                
        }

        if (DetectHoles.freezeLost)
        {
            
            for (int i = 0; i < shotNumbers.Length; i++)
                shotNumbers[i].SetActive(false);

            float step = 100.0f * Time.deltaTime; // calculate distance to move
            Vector3 freezeCameraPosition = new Vector3(player.transform.position.x, player.transform.position.y + 2.5f, player.transform.position.z + 4f);
            Camera.main.transform.position = Vector3.MoveTowards(transform.position, freezeCameraPosition, step);
            if (Camera.main.transform.position == freezeCameraPosition)
            {
                Time.timeScale = 0;
                
                for (int i = 0; i < gameOverUI.Length; i++)
                    gameOverUI[i].SetActive(true);
                // LOST 2 COLORS
                lost2Colors.SetActive(true);

            }

        }
    }
       
}
