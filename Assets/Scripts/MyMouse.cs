using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMouse : MonoBehaviour
{
    public static Vector3 playerPos;
    bool beingDragged;
    Vector3 initialWorldMousePos = Vector3.zero;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
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
