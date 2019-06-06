using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMouse : MonoBehaviour
{
    
    public static Vector3 playerPos;
    public static bool beingDragged;
    public static bool onRed, onYellow, onBlue;
    Vector3 initialWorldMousePos = Vector3.zero;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        onRed = false;
        onYellow = false;
        onBlue = true;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("RED: " + onRed);
       // Debug.Log("BLUE: " + onBlue);
       // Debug.Log("YELLOW: " + onYellow);

        playerPos = player.transform.position;
        if(playerPos.x >0 && playerPos.x < 1)
        {
            onRed = true;
            onBlue = false;
            onYellow = false;
        }else if(playerPos.x > 1 && playerPos.x < 2)
        {
            onRed = false;
            onBlue = true;
            onYellow = false;
        }else if(playerPos.x > 2 && playerPos.x < 3)
        {
            onRed = false;
            onBlue = false;
            onYellow = true;

        }
       // Debug.Log("Dragging = " + beingDragged);
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        if (Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("FIRE");
            initialWorldMousePos = mouseWorldPos;
            beingDragged = true;
            //player.transform.localPosition = Vector3.zero;

            // player.transform.position = mousePos;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            beingDragged = false;
        }

        if (beingDragged)
        {

            if (new Vector2(mouseWorldPos.x - initialWorldMousePos.x, mouseWorldPos.y - initialWorldMousePos.y).magnitude > 0.2)
            {
                if (initialWorldMousePos.x > mouseWorldPos.x )
                {
                    if (player.transform.position.x < 0.5)
                    {

                    }
                    else
                    {
                        player.transform.position = new Vector3(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
                    }
                        

                }
                else
                {
                    if (player.transform.position.x <=2.2)
                        player.transform.position = new Vector3(player.transform.position.x +1, player.transform.position.y, player.transform.position.z);


                }
                beingDragged = false;

            }




            // beingDragged = false;

        }



    }
}
