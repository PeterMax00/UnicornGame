using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMoveCamera : MonoBehaviour
{
    private Animator cameraAnimation;
    private bool start;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        cameraAnimation = GetComponent<Animator>();
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            cameraAnimation.enabled = !cameraAnimation.enabled;
            start = false;
        }

        if (Camera.main.transform.eulerAngles.x >= 25.6f)
        {
           
            SceneManager.LoadScene("GameNewCtrlH", LoadSceneMode.Single);
           
        }
    }

    public void StartGameCamera()
    {
        Debug.Log("CLICKED");
        start = true;
    }
}
