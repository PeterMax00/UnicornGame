using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpriteShot : MonoBehaviour
{

    public Sprite[] numbers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

            this.gameObject.GetComponent<SpriteRenderer>().sprite = numbers[blueShots.blueShotsCounter];
    }
}
