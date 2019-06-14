using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip iceSound,wrongSound, stringTensionSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        iceSound = Resources.Load<AudioClip>("iceSound");
        wrongSound = Resources.Load<AudioClip>("wrongSound");
        //stringTensionSound = Resources.Load<AudioClip>("stringTension");
        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "iceSound":
                audioSrc.PlayOneShot(iceSound);
                break;
            case "wrongSound":
                audioSrc.PlayOneShot(wrongSound);
                break;

            case "stringTension":

                break;
        }

    }

}
